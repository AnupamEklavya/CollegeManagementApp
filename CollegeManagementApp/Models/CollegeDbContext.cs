using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CollegeManagementApp.Models;

namespace CollegeManagementApp.Models
{
    public class CollegeDbContext: IdentityDbContext<ApplicationUser>
    {
        public CollegeDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<CollegeManagementApp.Models.Branch> Branch { get; set; }
        public DbSet<CollegeManagementApp.Models.Subject> Subject { get; set; }
    }
}
