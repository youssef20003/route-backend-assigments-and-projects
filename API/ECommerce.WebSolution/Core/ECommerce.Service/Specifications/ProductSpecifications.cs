using ECommerce.Domain.Models.Product;
using ECommerce.Shared;
using ECommerce.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Specifications
{
    internal class ProductSpecifications : BaseSpecifications<Product, int>
    {
        public ProductSpecifications(ProductQueryParams productQueryParams) :
            base(P=>(!productQueryParams.BrandId.HasValue || P.BrandId == productQueryParams.BrandId) && 
                    (!productQueryParams.TypeId.HasValue || P.TypeId == productQueryParams.TypeId) &&
                    (string.IsNullOrEmpty(productQueryParams.SearchValue) || P.Name.ToLower().Contains(productQueryParams.SearchValue.ToLower())))
        {
            AddInclude(p => p.Brand);
            AddInclude(p => p.Type);

            switch (productQueryParams.SortingOptions)
            {
                case ProductSortingOptions.NameAsc:
                    AddOrderBy(p=>p.Name);
                    break;
                case ProductSortingOptions.NameDesc:
                    AddOrderByDesc(p => p.Name);
                    break;
                case ProductSortingOptions.PriceAsc:
                    AddOrderBy(p => p.Price);
                    break;
                case ProductSortingOptions.PriceDesc:
                    AddOrderByDesc(p => p.Price);
                    break;
                default:
                    break;
            }

            ApplyPagination(productQueryParams.PageIndex , productQueryParams.PageSize);
        }

        public ProductSpecifications(int id) : base(p=>p.Id == id)
        {
            AddInclude(p => p.Brand);
            AddInclude(p => p.Type);
        }
    }
}
