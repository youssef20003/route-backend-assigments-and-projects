using AutoMapper;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts.Repos;
using ECommerce.Domain.Contracts.UOW;
using ECommerce.Persistence.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Persistence.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Service.Services
{
    public class ServiceManager(IMapper mapper , IUOW UOW , IBasketRepo basketRepo , UserManager<ApplicationUser> userManager , IConfiguration configuration ) : IServiceManager
    {
        public readonly Lazy<IProductService> LazyProductServices = new Lazy<IProductService>(() => new ProductService(UOW, mapper) );
        public IProductService ProductService => LazyProductServices.Value;


        public readonly Lazy<IBasketService> LazyBasketServices =
            new Lazy<IBasketService>(() => new BasketServices(basketRepo, mapper));

        public IBasketService BasketService => LazyBasketServices.Value;


        public readonly Lazy<IAuthenticationService> LazyAuthenticationServices =
            new Lazy<IAuthenticationService>(() => new AuthenticationService(userManager , configuration , mapper));
        public IAuthenticationService AuthenticationService  => LazyAuthenticationServices.Value;


        public readonly Lazy<IOrderService> LazyOrderService =
            new Lazy<IOrderService>(() => new OrderService( mapper , basketRepo , UOW));
       
        public IOrderService OrderService => LazyOrderService.Value;
    }
}
