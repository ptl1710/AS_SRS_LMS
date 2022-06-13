using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class ClassAddRequest
    {
        [Required]
        public string className { get; set; } = string.Empty;
        [Required]
        public DateTime startDate { get; set; }
        [Required]
        public DateTime endDate { get; set; }
        [Required]
        public int subjectId { get; set; }
    }
}
