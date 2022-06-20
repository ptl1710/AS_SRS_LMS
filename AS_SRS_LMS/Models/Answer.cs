using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Answer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string AnswerId { get; set; }
        public string Content { get; set; }
        public bool RightWrong { get; set; }

        public int IdExam { get; set; }
        public Exam exam { get; set; }
    }
}
