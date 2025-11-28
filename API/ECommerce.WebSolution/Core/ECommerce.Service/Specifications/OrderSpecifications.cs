using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Domain.Models.Order;

namespace ECommerce.Service.Specifications
{
    public class OrderSpecifications:BaseSpecifications<Order , Guid>
    {
        public OrderSpecifications(string Email) : base(o => o.UserEmail == Email)
        {
            AddInclude(o => o.Items);
            AddInclude(o => o.DeliveryMethod);

            AddOrderByDesc(o => o.OrderData);
        }

        public OrderSpecifications(Guid id) : base(o => o.Id == id)
        {
            AddInclude(o => o.Items);
            AddInclude(o => o.DeliveryMethod);

            
        }
    }
}
