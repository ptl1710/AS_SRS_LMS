using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Interface
{
    public class SubjectRequest
    {
        [Required]
        public string SubjectName { get; set; } = string.Empty;
        [Required]
        public string Period { get; set; } = string.Empty;
    }
}
