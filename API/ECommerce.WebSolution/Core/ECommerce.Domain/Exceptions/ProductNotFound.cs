using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Exceptions
{
    public class ProductNotFound(int id):NotFoundException($"product with id : {id} is not found")
    {
    }
}
