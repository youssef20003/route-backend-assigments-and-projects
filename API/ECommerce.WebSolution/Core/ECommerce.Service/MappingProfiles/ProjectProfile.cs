using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ECommerce.Domain.Models.Baskets;
using ECommerce.Domain.Models.Product;
using ECommerce.Persistence.Identity.Models;
using ECommerce.Shared.DTOS;
using ECommerce.Shared.DTOS.BasketDtos;
using ECommerce.Shared.DTOS.IdentityDtos;
using Microsoft.Extensions.Configuration;

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
        }

    }
}
