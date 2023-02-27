using Microsoft.AspNetCore.Identity;

namespace CollegeManagementApp.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string StudentName { get; set; }
    }
}
