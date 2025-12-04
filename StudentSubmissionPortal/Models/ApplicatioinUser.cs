using Microsoft.AspNetCore.Identity;

namespace StudentSubmissionPortal.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; } 
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public DateTime DateTimeCreated { get; set; }

        // Only for students
        public int? ClassId { get; set; }
        public Class Class { get; set; }
    }
}
