using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class ResetPasswordRequest
    {
        [Required]
        public string Token { get; set; } = string.Empty;
        [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters!!!")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string confirmPassword { get; set; } = string.Empty;
    }
}
