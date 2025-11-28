using ECommerce.Shared;
using ECommerce.Shared.DTOS;
using ECommerce.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Abstraction.IServices
{
    public interface IProductService
    {
        Task<PaginationResult<ProductDto>> GetAllProductsAsync(ProductQueryParams productQueryParams);
        Task<IEnumerable<TypeDto>> GetAllTypesAsync();
        Task<IEnumerable<BrandDto>> GetAllBransAsync();

        Task<ProductDto> GetProductByIdAsync(int id);
    }
}
