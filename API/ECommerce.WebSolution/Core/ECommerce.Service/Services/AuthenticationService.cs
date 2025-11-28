using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Exceptions;
using ECommerce.Persistence.Identity.Models;
using ECommerce.Shared.DTOS.IdentityDtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Service.Services
{
    public class AuthenticationService(UserManager<ApplicationUser> userManager , IConfiguration configuration , IMapper mapper):IAuthenticationService
    {
        public async Task<UserDto> LoginAsync(LoginDto dto)
        {
            var User = await userManager.FindByEmailAsync(dto.Email) ?? throw new UserNotFoundException(dto.Email);

            var IsPasswordValid = await userManager.CheckPasswordAsync(User, dto.Password);

            if (IsPasswordValid)
            {
                return new UserDto()
                {
                    Email = User.Email,
                    DisplayName = User.DisplayName,
                    Token = await CreateTokenAsync(User)
                };
            }
            else
            {
                throw new UnAuthorizedcs();
            }
        }

        public async Task<UserDto> RegisterAsync(RegisterDto dto)
        {
            var user = new ApplicationUser()
            {
                DisplayName = dto.DisplayName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                UserName = dto.UserName

            };

            var res = await userManager.CreateAsync(user, dto.Password);

            if (res.Succeeded)
            {
                return new UserDto()
                {
                    Email = user.Email,
                    DisplayName = user.DisplayName,
                    Token = await CreateTokenAsync(user)
                };
            }
            else
            {
                var Errors = res.Errors.Select(e => e.Description).ToList();
                throw new BadRequestException(Errors);
            }
        }

        public  async Task<bool> CheckEmailAsync(string Email)
        {
            var user = await userManager.FindByEmailAsync(Email);
            return user is not null;
        }

        public async Task<AddressDto> GetCurrentUserAddressAsync(string Email)
        {
            var user = await userManager.Users.Include(u => u.Address).FirstOrDefaultAsync(e => e.Email == Email);

            if (user.Address is not null)
            {
                return mapper.Map<Address, AddressDto>(user.Address);
            }
            else
            {
                throw new AddressInUseException(user.UserName);
            }
        }

        public async Task<AddressDto> UpdateCurrentUserAddressAsync(string Email, AddressDto dto)
        {
            var user = await userManager.Users.Include(u => u.Address).FirstOrDefaultAsync(e => e.Email == Email);


            if (user.Address is not null)
            {
                user.Address.Street = dto.Street;
                user.Address.City = dto.City;
                user.Address.Country = dto.Country;
                user.Address.FirstName = dto.FirstName;
                user.Address.LastName = dto.lastName;
              
            }
            else
            {
                user.Address =mapper.Map<AddressDto, Address>(dto);
            }

            await userManager.UpdateAsync(user);

            return mapper.Map<Address, AddressDto>(user.Address);
        }

        public async Task<UserDto> GetCurrentUserAsync(string Email)
        {
            var user = await userManager.FindByEmailAsync(Email);

            return new UserDto()
            {
                DisplayName = user.DisplayName,
                Email = user.Email,
                Token = await CreateTokenAsync(user)

            };
        }

        private async Task<string> CreateTokenAsync(ApplicationUser user)
        {
            var UserClaims = new List<Claim>()
            {
                new(ClaimTypes.Email ,user.Email),
                new(ClaimTypes.Name ,user.UserName),
                new(ClaimTypes.NameIdentifier ,user.Id),

            };

            var Roles = await userManager.GetRolesAsync(user);

            foreach (var role in Roles)
            {
                UserClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var SecurtyKey = configuration.GetSection("JWTOptions")["SecurityKey"];
            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurtyKey));

            var cred = new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);

            var Token = new JwtSecurityToken
            (
                issuer: configuration.GetSection("JWTOptions")["Issuer"],
                audience: configuration.GetSection("JWTOptions")["Audience"],
                claims: UserClaims,
                expires: DateTime.Now.AddDays(2),
                signingCredentials: cred

            );

            return new JwtSecurityTokenHandler().WriteToken(Token);

        }
    }
}
