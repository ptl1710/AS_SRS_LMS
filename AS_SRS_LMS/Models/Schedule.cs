using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AS_SRS_LMS.Models
{
    public class Schedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int scheduleId { get; set; }

        public DateTime Time { get; set; }

        public DayOfWeek dayOfWeek { get; set; }

        public int subjectId { get; set; }
        public Subject subject { get; set; }
    }
}
