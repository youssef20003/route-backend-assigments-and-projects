using Humanizer;
using IKEA.BLL.Dtos.DepartmentDtos;
using IKEA.BLL.Services.Department;
using IKEA.PL_S3_demo_.ViewModels.DepartmentVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;

namespace IKEA.PL_S3_demo_.Controllers
{
    [Authorize(Roles = "NUser")]
    public class departmentController : Controller
    {
        private readonly IDepartmentInterface _department;
        private readonly ILogger<departmentController> logger;

        public departmentController(IDepartmentInterface department , ILogger<departmentController> logger) 
        {
           _department = department;
            this.logger = logger;
        }

        public IDepartmentInterface Department { get; }

        public IActionResult Index()
        {
            ViewData["Message"] = " hello from view data";
            var depts = _department.GetAllDepartmants();
            return View(depts);
        }

        [HttpGet]
        [Authorize(Roles = "NUser")]
        public IActionResult Create() { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(DepartmentViewModel dvm)
        {
            if (ModelState.IsValid) 
            {
                CreatedDepartmnetDto dept = new CreatedDepartmnetDto()
                {
                    
                    Name = dvm.Name,
                    Description = dvm.Description,
                    Code = dvm.Code,
                };
                try
                {
                    int res = _department.AddDepartmant(dept);
                    if (res != 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "department cant be created");
                        return View(dept);
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError(ex.Message);
                    return View(dept);
                }      
               
            }
            else
            {
                return View(dvm);
            }
        }

        [HttpGet]
        public IActionResult Details(int? id) 
        { 
            if(id == null)
            {
                return BadRequest();
            }
            
            var dept = _department.GetById(id.Value);
                
            if (dept == null)
            {
                return NotFound();
            }
            return View(dept);
            
        }

        [HttpGet]
        public IActionResult Edit(int? id) 
        {
            if (id == null)
            {
                return BadRequest();
            }

            var dept = _department.GetById(id.Value);

            if (dept == null)
            {
                return NotFound();
            }
            var viewdept = new DepartmentViewModel()
            {
                Id =dept.Id,
                Name = dept.Name,
                Description = dept.Description,
                Code = dept.Code,
            };
            return View(viewdept);

        }

        [HttpPost]
        public IActionResult Edit(DepartmentViewModel dvm) {

            if (!ModelState.IsValid) return View(dvm);
            var dept = new UpdatedDepartmentDto()
            {
                Id = dvm.Id,
                Name = dvm.Name,
                Description = dvm.Description,
                Code = dvm.Code,
            };
            try
            {
                int res = _department.UpdateDepartment(dept);
                if (res != 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "department cant be created");
                    return View(dvm);
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return View(dvm);
            }

            return Redirect("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();
            var dept = _department.GetById(id.Value);

            if(dept is null)
            {
                return NotFound();
            }
            return View(dept);
        }

        [HttpPost]
        public IActionResult Delete(int deptid)
        {
            try
            {
                var isdeleted = _department.DeleteDepartment(deptid);
                if (isdeleted != null) return RedirectToAction("Index");


            }
            catch (Exception ex) {
                logger.LogError(ex.Message);
            }

            return RedirectToAction(nameof(Delete), new {id = deptid});
        }

    }
}
