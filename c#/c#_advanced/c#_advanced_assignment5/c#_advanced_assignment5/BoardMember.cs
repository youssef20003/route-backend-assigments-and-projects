using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment5
{
    public class BoardMember:Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.Resigned });
        }
    }
}
