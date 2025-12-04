using System.ComponentModel.DataAnnotations;

namespace StudentSubmissionPortal.Models
{
    public class StudentProfile
    {
        public int Id { get; set; }

        public string UserId { get; set; } // Foreign key to AspNetUsers table

        [StringLength(100)]
        public string FullName { get; set; }

        public int ClassId { get; set; } // Foreign key to Class entity   
        public  Class Class { get; set; }

        public List<Submission> Submissions { get; set; }




    }
}
