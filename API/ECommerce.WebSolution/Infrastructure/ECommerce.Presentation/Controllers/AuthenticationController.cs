using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Abstraction.IServices;
using ECommerce.Persistence.Identity.Models;
using ECommerce.Shared.DTOS.IdentityDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace ECommerce.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController(IServiceManager serviceManager , UserManager<ApplicationUser> userManager):ControllerBase
    {
        private readonly IServiceManager _serviceManager = serviceManager;

        [HttpPost("Login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto dto)
        {
            var user = await _serviceManager.AuthenticationService.LoginAsync(dto);

            return Ok(user);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto dto)
        {
            var user = await _serviceManager.AuthenticationService.RegisterAsync(dto);

            return Ok(user);
        }

        [Authorize]
        [HttpGet("CheckEmail")]
        public async Task<ActionResult<bool>> CheckEmail(string Email)
        {
            var res = await _serviceManager.AuthenticationService.CheckEmailAsync(Email);
            return Ok(res);
        }


        [Authorize]
        [HttpGet("CurrentUser")]
        public async Task<ActionResult<UserDto>> GetCurrentuser()
        {
            var Email = User.FindFirstValue(ClaimTypes.Email);
            var AppUser = await _serviceManager.AuthenticationService.GetCurrentUserAsync(Email);
            return Ok(AppUser);
        }

        [Authorize]
        [HttpGet("GerCurrentUserAddress")]
        public async Task<ActionResult<UserDto>> GetCurrentuserAddress()
        {
            var Email = User.FindFirstValue(ClaimTypes.Email);
            var Adrress = await _serviceManager.AuthenticationService.GetCurrentUserAddressAsync(Email);
            return Ok(Adrress);
        }

        [HttpPut("Address")]
        public async Task<ActionResult<AddressDto>> UpdateCurrentUserAddress(AddressDto dto)
        {
            var Email = User.FindFirstValue(ClaimTypes.Email);
            var UpdatedAddress = await _serviceManager.AuthenticationService.UpdateCurrentUserAddressAsync(Email, dto);
            return Ok(UpdatedAddress);
        }

    }
}
