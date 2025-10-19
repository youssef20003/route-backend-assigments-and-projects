using System.ComponentModel.DataAnnotations;

namespace IKEA.PL_S3_demo_.ViewModels.DepartmentVM
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage ="code is requird")]
        public string Code { get; set; }
    }
}
