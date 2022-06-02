using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string idExam { get; set; }
        public string nameExam { get; set; }
        public DateTime createDate { get; set; }
        public string contentExam { get; set; }
        public float Time { get; set; }
        public string Unit { get; set; }
        public string ExamWork { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }

        public int ResultId { get; set; }
        public Result Results { get; set; }
        public int TestScheduleId { get; set; }
        public TestSchedule TestSchedule { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }


    }
}
