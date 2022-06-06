using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int subjectId { get; set; }
        public string subjectName { get; set; }

        public int numberOfPeriod { get; set; }
        public int examId { get; set; }
        public Exam Exam { get; set; }
        public List<Class> Class { get; set; }
        public List<Question> questions { get; set; }
        public List<Schedule> schedules { get; set; }

        public List<Document> documents { get; set; }


    }
}
