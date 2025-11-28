using AutoMapper;
using AutoMapper.Execution;
using ECommerce.Domain.Models.Order;
using ECommerce.Shared.DTOS.OrderDto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.MappingProfiles
{
    public class OrderPictrueUrlResolver(IConfiguration configuration) : IValueResolver<OrderItem ,OrderItemDto , string>
    {
        public string Resolve(OrderItem source, OrderItemDto destination, string destMember, ResolutionContext context)
        {
            if (string.IsNullOrEmpty(source.Product.PictureUrl)) return string.Empty;
            else
            {
                var url = $"{configuration.GetSection("Urls")["BaseURL"]}{source.Product.PictureUrl}";
                return url;
            }
        }
    }
}
