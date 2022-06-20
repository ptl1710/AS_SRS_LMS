using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AS_SRS_LMS.Models
{
    public class ResultExam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ResultId { get; set; }
        public float Score { get; set; }
        public DateTime DayExam { get; set; }
        public int IdExam { get; set; }
        public Exam exam { get; set; }
        public int IdUser { get; set; }
        public User user { get; set; }


    }
}
