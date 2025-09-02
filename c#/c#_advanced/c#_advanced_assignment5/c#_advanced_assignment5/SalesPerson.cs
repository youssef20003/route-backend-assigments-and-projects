using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment5
{
    public class SalesPerson:Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.FailedTarget });
                return false;
            }
            return true;
        }

        public override bool RequestVacation(DateTime From, DateTime To)
        {
            return true; 
        }

    }
}
