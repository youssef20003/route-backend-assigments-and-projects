using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_assignment_3.Models
{
    [Owned]
    public class EmpAddress
    {
    
       
            public string City { get; set; }
            public string Country { get; set; }
            public string Street { get; set; }
        
    }
}
