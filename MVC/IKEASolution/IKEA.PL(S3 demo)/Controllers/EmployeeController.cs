using IKEA.BLL.Dtos.DepartmentDtos;
using IKEA.BLL.Dtos.EmployeeDtos;
using IKEA.BLL.Services.Department;
using IKEA.BLL.Services.EmployeeServices;
using IKEA.DAL.Models.Departmnet;
using IKEA.PL_S3_demo_.ViewModels.DepartmentVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IKEA.PL_S3_demo_.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;
        private readonly IWebHostEnvironment _environment;
        public EmployeeController(IEmployeeService employeeService , ILogger<EmployeeController> logger , IWebHostEnvironment environment )
        {
            _employeeService = employeeService;
         
            _logger = logger;
            _environment = environment;
        }
        public IActionResult Index(string? searchValue)
        {
            if(searchValue is null)
            {
               
                return View(_employeeService.GetAllEmployees());

            }
            else
            {
             return View(_employeeService.GetSearchedEmployees(searchValue));
            }
          
        }

        [HttpGet]
        public IActionResult Create()
        {
          
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreatedEmployeeDto dto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    int res = _employeeService.AddEmployee(dto);
                    if (res != 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Employee cant be added");
                        return View(dto);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    return View(dto);
                }

            }
            else
            {
                return View(dto);
            }
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var emp = _employeeService.GetById(id.Value);

            if (emp == null)
            {
                return NotFound();
            }
            return View(emp);

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var emp = _employeeService.GetById(id.Value);

            if (emp == null)
            {
                return NotFound();
            }
            var mappedemployee = new UpdatedEmployeeDto()
            {
                Id = emp.Id,
                Name = emp.Name,
                Age = emp.Age,
                Address = emp.Address,
                HiringDate = emp.HiringDate,
                PhoneNumber = emp.PhoneNumber,
                Email = emp.Email,
                Gender = Enum.TryParse<IKEA.DAL.Models.Shared.Gender>(emp.Gender, out var gender) ? gender : default,
                EmployeeType = Enum.TryParse<IKEA.DAL.Models.Employee.EmployeeType>(emp.EmployeeType, out var employeeType) ? employeeType : default,
                IsActive = emp.IsActive
            };
            return View(mappedemployee);

        }

        [HttpPost]
        public IActionResult Edit(UpdatedEmployeeDto dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            try
            {
                int res = _employeeService.UpdateEmployee(dto);

                if (res > 0)
                    return RedirectToAction("Index");

                ModelState.AddModelError(string.Empty, "Employee can't be updated");
                return View(dto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating employee");
                ModelState.AddModelError(string.Empty, "Unexpected error occurred");
                return View(dto);
            }
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) return BadRequest();
            var dept = _employeeService.GetById(id.Value);

            if (dept is null)
            {
                return NotFound();
            }
            return View(dept);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            try
            {
                var isdeleted = _employeeService.DeleteEmployeet(id);
                if (isdeleted != null) return RedirectToAction("Index");


            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return RedirectToAction(nameof(Delete), new { id = id });
        }
    }
}
