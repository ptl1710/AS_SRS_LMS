using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestId { get; set; }
        public string NameTest { get; set; }
        public DateTime Date { get; set; }
        public int Time { get; set; }
        public bool Status { get; set; }
        public int IdSubject { get; set; }
        public Subject Subject { get; set; }
        public int IdUser { get; set; }
        public User user { get; set; }
    }
}
