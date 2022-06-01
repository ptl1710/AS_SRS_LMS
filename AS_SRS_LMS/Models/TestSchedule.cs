using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class TestSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string idTestSchedule { get; set; }
        public string nameTestSchedule { get; set; }
        public DateTime testDay { get; set; }
      
    }
}
