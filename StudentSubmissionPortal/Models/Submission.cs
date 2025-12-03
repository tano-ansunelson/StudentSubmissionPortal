namespace StudentSubmissionPortal.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public int StudentProfileId { get; set; } // Foreign key to StudentProfile entity
        public StudentProfile StudentProfile { get; set; }
        public int ProjectId { get; set; } // Foreign key to Project entity
        public Project Project { get; set; }
        public DateTime SubmittedAt { get; set; }
        public String FilePath { get; set; }
        public String ReviewComments { get; set; }

        public int? Score { get; set; }


    }
}
