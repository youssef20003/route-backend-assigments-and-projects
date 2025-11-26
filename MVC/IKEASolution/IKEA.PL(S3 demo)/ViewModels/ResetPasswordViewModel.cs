using System.ComponentModel.DataAnnotations;

namespace IKEA.PL_S3_demo_.ViewModels
{
    public class ResetPasswordViewModel
    {
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; }

        public string Token { get; set; }
        public string Email { get; set; }
    }
}
