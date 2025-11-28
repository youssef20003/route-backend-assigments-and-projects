using AutoMapper;
using ECommerce.Domain.Models.Baskets;
using ECommerce.Domain.Models.Order;
using ECommerce.Domain.Models.Product;
using ECommerce.Persistence.Identity.Models;
using ECommerce.Shared.DTOS;
using ECommerce.Shared.DTOS.BasketDtos;
using ECommerce.Shared.DTOS.IdentityDtos;
using ECommerce.Shared.DTOS.OrderDto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.MappingProfiles
{
    public class ProjectProfile:Profile
    {
        public ProjectProfile(IConfiguration configuration)
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dist=>dist.BrandName,option=>option
                    .MapFrom(src=>src.Brand.Name))
                .ForMember(dist => dist.TypeName, option => option
                    .MapFrom(src => src.Type.Name))
                .ForMember(dest=>dest.PictureUrl , options=>options
                    .MapFrom(new PictureUrlResolver(configuration)));

            CreateMap<ProductBrand, BrandDto>();
            CreateMap<ProductType, TypeDto>();



            CreateMap<CustomerBasket , BasketDto>().ReverseMap();
            CreateMap<BasketItem, BasketItemDto>().ReverseMap();

            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<AddressDto, OrderAddress>().ReverseMap();
            CreateMap<Order, OrderToReturnDto>().ForMember(d => d.DeliveryMethod, options => options.MapFrom(src => src.DeliveryMethod.ShortName)); //we wil not every reverse map this 

            CreateMap<OrderItem, OrderItemDto>().ForMember(src => src.ProductName, options => options.MapFrom(src => src.Product.ProductName))
                .ForMember(src => src.ProductPictureUrl, options => options.MapFrom(new OrderPictrueUrlResolver(configuration)));


            CreateMap<DeliveryMethod, DeliveryMethodDto>().ReverseMap();
        }

    }
}
