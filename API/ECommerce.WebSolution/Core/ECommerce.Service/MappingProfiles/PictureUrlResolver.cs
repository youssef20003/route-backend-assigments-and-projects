using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Execution;
using ECommerce.Domain.Models.Product;
using ECommerce.Shared.DTOS;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Service.MappingProfiles
{
    public class PictureUrlResolver(IConfiguration configuration):IValueResolver<Product , ProductDto , string>
    {
        private readonly IConfiguration _configuration = configuration;

        public string Resolve(Product source, ProductDto destination, string destMember, ResolutionContext context)
        {
            if (string.IsNullOrEmpty(source.PictureUrl))
            {
                return string.Empty;
            }
            else
            {
                var  Url = $"{_configuration.GetSection("Urls")["BaseUrl"]}{source.PictureUrl}";

                return Url;
            }

        } 
    }
}
