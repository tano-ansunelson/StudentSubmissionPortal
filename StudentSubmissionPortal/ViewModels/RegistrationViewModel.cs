using System.ComponentModel.DataAnnotations;

namespace StudentSubmissionPortal.ViewModels
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage ="Full name is required")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress(ErrorMessage ="Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage ="Password must be at least 6 characters long")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage ="Role is required")]
        public string Role { get; set; }   // Student or Supervisor
        public int? ClassId { get; set; }  // Only for students

    }
}
