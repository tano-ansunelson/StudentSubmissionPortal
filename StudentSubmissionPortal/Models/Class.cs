using System.ComponentModel.DataAnnotations;

namespace StudentSubmissionPortal.Models
{
    public class Class
    {

        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public List<StudentProfile> StudentProfiles { get; set; }
    }
}
