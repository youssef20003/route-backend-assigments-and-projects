using ECommerce.Shared.DTOS.OrderDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Abstraction.IServices;

namespace ECommerce.Presentation.Controllers
{

    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        
        public OrderController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        public async Task<ActionResult<OrderToReturnDto>> CreateOrder(OrderDto orderDto)
        {

            var email = User.FindFirstValue(ClaimTypes.Email);

            var Order = await _serviceManager.OrderService.CreateOrderAsync(orderDto, email);

            return Ok(Order);
        }

        [HttpGet("DeliveryMethods")]
        public async Task<ActionResult<IEnumerable<DeliveryMethodDto>>> GetDeliveryMethods()
        {
            var DMs = await _serviceManager.OrderService.GetDeliveryMethodsAsync();
            return Ok(DMs);
        }

        [HttpGet("AllOrders")]
        public async Task<ActionResult<IEnumerable<OrderToReturnDto>>> GetAllOrders()
        {
            var Email = User.FindFirstValue(ClaimTypes.Email);
            var Orders = await _serviceManager.OrderService.GetAllOrdersAsync(Email);
            return Ok(Orders);
        }
        [HttpGet]
       public async Task<ActionResult<OrderToReturnDto>> GetOrderById(Guid Orderid)
        {
            var Order = await _serviceManager.OrderService.GetOrderById(Orderid);
            return Ok(Order);
        }
    }
}
