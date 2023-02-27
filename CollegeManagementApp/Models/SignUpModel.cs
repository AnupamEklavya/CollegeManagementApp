using System.ComponentModel.DataAnnotations;

namespace CollegeManagementApp.Models
{
    public class SignUpModel
    {
        [Required]
        public string StudentName{ get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
