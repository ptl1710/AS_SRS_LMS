using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string examId { get; set; }
        public string examName { get; set; }
        public DateTime examDate { get; set; }
        public float Time { get; set; }
        public string Unit { get; set; }
        public bool Status { get; set; }

        public int subjectId { get; set; }
        public Subject subject { get; set; }

        public int typeExamId { get; set; }
        public TypeExam typeExam { get; set; }


    }
}
