using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string idExam { get; set; }
        public DateTime createDate { get; set; }
        public string contentExam { get; set; }
        public float Time { get; set; }
        public string Unit { get; set; }
        public float Marks { get; set; }
        

    }
}
