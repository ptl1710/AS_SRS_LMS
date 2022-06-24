using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Interface
{
    public class ClassRequest
    {
        [Required]
        public string ClassName { get; set; } = string.Empty; 
        [Required]
        public string Amount { get; set; } =  string.Empty;     
    }
}

