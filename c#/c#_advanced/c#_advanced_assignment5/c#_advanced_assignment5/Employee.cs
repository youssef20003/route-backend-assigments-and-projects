using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced_assignment5
{
    public enum LayOffCause
    {
        VacationStockNegative,
        AgeAbove60,
        FailedTarget,
        Resigned
    }
    public class EmployeeLayOffEventArgs:EventArgs
    {
        public LayOffCause Cause { get; set; }
    }
    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;


        protected virtual void OnEmployeeLayOff (EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke (this, e);
        }

        public int EmployeeID { get; set; }

        public DateTime BirthDate
        {
            get;
            set;
        }

        public int VacationStock
        {
            get;
            set;
        }

        public virtual bool RequestVacation(DateTime From, DateTime To)
        {
            int days = (To - From).Days + 1;
            VacationStock -= days;
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.VacationStockNegative });
                return false;
            }
            return true;
        }

        public void EndOfYearOperation()
        {
            int age = DateTime.Now.Year - BirthDate.Year;
            if (BirthDate > DateTime.Now.AddYears(-age)) age--; 

            if (age > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = LayOffCause.AgeAbove60 });
            }
        }

    }
}
