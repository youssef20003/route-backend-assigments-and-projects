using System.ComponentModel.DataAnnotations;

namespace IKEA.PL_S3_demo_.ViewModels
{
    public class ForgetPasswordViewModel
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
