using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Exceptions
{
    public class AddressNotFoundExpection(string name):NotFoundException($"user name {name} has no addrress ")
    {
    }
}
