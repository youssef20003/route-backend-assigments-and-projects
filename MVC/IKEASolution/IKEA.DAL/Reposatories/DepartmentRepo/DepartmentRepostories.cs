using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IKEA.DAL.Contexts;
using IKEA.DAL.Models.Departmnet;
using IKEA.DAL.Reposatories.GenaricRepo;

namespace IKEA.DAL.Reposatories.DepartmentRepo
{
    public class DepartmentRepostories : GenaricRepo<Department>, IDepartmentReposatery
    {
        private readonly ApplicationDBContext _context;
        public DepartmentRepostories(ApplicationDBContext context):base(context) 
        {
            _context = context;
        }


     
    }
}
