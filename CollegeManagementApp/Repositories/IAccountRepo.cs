using CollegeManagementApp.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace CollegeManagementApp.Repositories
{
    public interface IAccountRepo
    {
        Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(Login login);
    }
}
