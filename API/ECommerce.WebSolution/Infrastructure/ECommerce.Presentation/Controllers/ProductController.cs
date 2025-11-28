using ECommerce.Abstraction.IServices;
using ECommerce.Shared;
using ECommerce.Shared.DTOS;
using ECommerce.Shared.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ECommerce.Presentation.Controllers
{

    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ProductController(IServiceManager serviceManager):ControllerBase
    {
        private readonly IServiceManager _serviceManager = serviceManager;


        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaginationResult<ProductDto>>>> GetAllProducts([FromQuery]ProductQueryParams productQueryParams)
        {
            var Products = await _serviceManager.ProductService.GetAllProductsAsync(productQueryParams);
            return Ok(Products);
        }

        [HttpGet("Brands")]
        public async Task<ActionResult<IEnumerable<BrandDto>>> GetAllBrands()
        {
            var Brands = await _serviceManager.ProductService.GetAllBransAsync();
            return Ok(Brands);
        }

        [HttpGet("Types")]
        public async Task<ActionResult<IEnumerable<TypeDto>>> GetAllTypes()
        {
            var Types = await _serviceManager.ProductService.GetAllTypesAsync();
            return Ok(Types);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetproductById(int id)
        {
            var Product = await _serviceManager.ProductService.GetProductByIdAsync( id);
            return Ok(Product);
        }
    }
}
