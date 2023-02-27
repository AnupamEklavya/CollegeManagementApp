
using Microsoft.AspNetCore.Identity;

namespace CollegeManagementApp.Models
{
    public class Admission
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string Address { get; set; }
        public Branch branch { get; set; }
    }
}
