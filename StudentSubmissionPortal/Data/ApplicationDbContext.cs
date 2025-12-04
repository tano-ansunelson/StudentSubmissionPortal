using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentSubmissionPortal.Models;

namespace StudentSubmissionPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<IdentityUser> Users { get; set; }
        // Add your tables here
        public DbSet<Class> Classes { get; set; }
       
        public DbSet<StudentProfile> Students{ get; set; }
        public DbSet<SupervisorProfile> Supervisors { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet<Submission> Submissions { get; set; }
        

        // public DbSet<StudentProject> StudentProjects { get; set; }
    }
}
