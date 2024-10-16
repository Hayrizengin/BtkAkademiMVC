using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="E-mail is required.")]
        public String? Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "Firstname is required.")]
        public String? FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Lastname is required.")]
        public String? LastName { get; set; } = String.Empty;
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}
