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
        public DateTime DayLearn { get; set; }
        public int IdSubject { get; set; }
        public Subject subject { get; set; }
    }
}
