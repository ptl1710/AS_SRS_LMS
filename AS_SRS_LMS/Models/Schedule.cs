using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AS_SRS_LMS.Models
{
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleId { get; set; }

        public DateTime Time { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        [ForeignKey("detailSubject")]
        public int DetailSubjectId { get; set; }
        public detailSubject detailSubject { get; set; }
    }
}
