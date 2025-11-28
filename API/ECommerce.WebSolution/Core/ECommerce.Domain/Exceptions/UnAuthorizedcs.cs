using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Exceptions
{
    public class UnAuthorizedcs(string message = "invalid email or password"):Exception(message)
    {
    }
}
