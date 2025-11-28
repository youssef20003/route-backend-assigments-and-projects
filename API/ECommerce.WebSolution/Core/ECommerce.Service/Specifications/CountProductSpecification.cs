using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Models.Product;
using ECommerce.Shared;
using ECommerce.Shared.DTOS;

namespace ECommerce.Service.Specifications
{
    public class CountProductSpecification : BaseSpecifications<Product , int>
    {
        public CountProductSpecification(ProductQueryParams productQueryParams) : base(P => (!productQueryParams.BrandId.HasValue || P.BrandId == productQueryParams.BrandId) &&
            (!productQueryParams.TypeId.HasValue || P.TypeId == productQueryParams.TypeId) &&
            (string.IsNullOrEmpty(productQueryParams.SearchValue) || P.Name.ToLower().Contains(productQueryParams.SearchValue.ToLower())))
        {

        }

    }
}
