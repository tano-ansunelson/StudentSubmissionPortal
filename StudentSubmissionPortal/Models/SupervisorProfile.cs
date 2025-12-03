using System.ComponentModel.DataAnnotations;

namespace StudentSubmissionPortal.Models
{
    public class SupervisorProfile
    {
        public int Id { get; set; }

        public string UserId { get; set; } // Foreign key to AspNetUsers table

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(100)]
        public string Department { get; set; }
       

        public List<Project> Projects { get; set; }



    }
}
