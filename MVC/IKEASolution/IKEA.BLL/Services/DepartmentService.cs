using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Reposatories.DepartmentRepo;

namespace IKEA.BLL.Services
{
    public class DepartmentService
    {
        private readonly IDepartmentReposatery _repo;
        public DepartmentService(IDepartmentReposatery Repostory)
        {
            _repo = Repostory;
        }



    }
}
