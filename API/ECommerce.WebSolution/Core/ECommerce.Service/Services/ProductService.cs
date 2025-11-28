using AutoMapper;
using ECommerce.Abstraction.IServices;
using ECommerce.Domain.Contracts.UOW;
using ECommerce.Domain.Models.Product;
using ECommerce.Service.Specifications;
using ECommerce.Shared;
using ECommerce.Shared.DTOS;
using ECommerce.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Exceptions;

namespace ECommerce.Service.Services 
{
    public class ProductService(IUOW uow , IMapper mapper) : IProductService
    {
        private readonly IUOW _uow = uow;
        private readonly IMapper _mapper = mapper;

        public async Task<PaginationResult<ProductDto>> GetAllProductsAsync(ProductQueryParams productQueryParams)
        {
            var spec = new ProductSpecifications(productQueryParams);
            var repo = _uow.getRepo<Product, int>();

            var products = await repo.GetAllWithSpecificatoinsAsync(spec);

            var  Data = _mapper.Map<IEnumerable<ProductDto>>(products);
            var Size = Data.Count();

            var CountSpec = new CountProductSpecification(productQueryParams);
            var Count = await repo.GetCOuntSpecificatoinsAsync(CountSpec);

            return new PaginationResult<ProductDto>(productQueryParams.PageIndex, Size, Count, Data);

        }

        public async Task<IEnumerable<TypeDto>> GetAllTypesAsync()
        {
            var Repo = _uow.getRepo<ProductType, int>();
            var Types = await Repo.GetAllAsync();
            var typeDto = _mapper.Map<IEnumerable<ProductType>, IEnumerable<TypeDto>>(Types);
            return typeDto;
        }

        public async Task<IEnumerable<BrandDto>> GetAllBransAsync()
        {
            var Repo = _uow.getRepo<ProductBrand, int>();
            var Brands = await Repo.GetAllAsync();
            var BrandsDto = _mapper.Map<IEnumerable<ProductBrand>, IEnumerable<BrandDto>>(Brands);
            return BrandsDto;
        }

        public async Task<ProductDto> GetProductByIdAsync(int id)
        {
            var spec = new ProductSpecifications(id);
            var Repo = _uow.getRepo<Product, int>();
            var Product = await Repo.GetByIdSpecificatoinsAsync(spec);

            if (Product is null)
            {
                throw new ProductNotFound(id);
            }

            var productDto = _mapper.Map<Product, ProductDto>(Product);

            
            return productDto;
        }
    }
}
