using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AS_SRS_LMS.Models
{
    public class Result
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int resultId { get; set; }
        public float Score { get; set; }
        public DateTime examDate { get; set; }

        public int examId { get; set; }
        public Exam Exam { get; set; }

        public int userId { get; set; }
        public User User { get; set; }


    }
}
