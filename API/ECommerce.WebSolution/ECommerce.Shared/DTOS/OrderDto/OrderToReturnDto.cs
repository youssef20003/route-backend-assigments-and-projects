using ECommerce.Shared.DTOS.IdentityDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Shared.DTOS.OrderDto
{
    public class OrderToReturnDto
    {
        public Guid Id { get; set; }

        public string userEmail { get; set; } = null!;

        public DateTimeOffset OrderDate { get; set; }

        public AddressDto Address { get; set; } = null!;

        public string DeliveryMethod { get; set; } = null!;

        public string OrderState { get; set; } = null!;

        public ICollection<OrderItemDto> Items { get; set; } = [];

        public decimal subtotal { get; set; }

        public decimal total { get; set; }
    }
}
