namespace CollegeManagementApp.Models
{
    public class Branch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public Subject Subjects { get; set; }
    }
}
