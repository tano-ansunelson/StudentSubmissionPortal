using System.ComponentModel.DataAnnotations;

namespace StudentSubmissionPortal.Models
{
    public class Project
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int SupervisorProfileId { get; set; } // Foreign key to SupervisorProfile entity
         
        public SupervisorProfile SupervisorProfile { get; set; }
        public List<Submission> Submissions { get; set; }
        public String FilePath { get; set; }    


    }
}
