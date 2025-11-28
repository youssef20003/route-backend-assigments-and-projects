using ECommerce.Abstraction.IServices;
using ECommerce.Shared.DTOS.BasketDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Presentation.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class BasketController (IServiceManager serviceManager) : ControllerBase
    {
        private readonly IServiceManager _serviceManager = serviceManager;


        [HttpGet]
        public async Task<ActionResult<BasketDto>> GetBasket(string Key)
        {
            var Basket = await _serviceManager.BasketService.GetBasketAsync(Key);

            return Ok(Basket);
        }

        [HttpPost]
        public async Task<ActionResult<ActionResult<BasketDto>>> CreateUpdateBasket(BasketDto Basket)
        {
            var internalBasket = await _serviceManager.BasketService.CreateOrUpdateBasketAsync(Basket);
            return Ok(internalBasket);
        }

        [HttpDelete("{Key}")]
        public async Task<ActionResult<bool>> DeleteBasket(string Key)
        {
            var res = await _serviceManager.BasketService.DeleteBasketAsync(Key);
            return Ok(res);
        }
    }
}
