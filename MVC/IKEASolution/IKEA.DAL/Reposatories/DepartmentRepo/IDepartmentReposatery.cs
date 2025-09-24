using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Models.Departmnet;

namespace IKEA.DAL.Reposatories.DepartmentRepo
{
    public interface IDepartmentReposatery
    {
        public IEnumerable<Department> GetAll(bool WithTracking = false);
        public Department GetById(int id);
        public int Add(Department  department);
        public int Update(Department department);
        public int Delete(int id);
    }
}
