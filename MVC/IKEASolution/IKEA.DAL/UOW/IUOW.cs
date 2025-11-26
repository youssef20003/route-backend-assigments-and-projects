using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Reposatories.DepartmentRepo;
using IKEA.DAL.Reposatories.EmployeeRepo;

namespace IKEA.DAL.UOW
{
    public interface IUOW
    {
        public IEmployeeRepo EmployeeRepo { get; set; }
        public IDepartmentReposatery DepartmentRepo { get; set; }

        public int Complete();
    }
}
