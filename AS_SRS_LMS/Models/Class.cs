using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int classId { get; set; }
        public string className { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public bool Status { get; set; }

        public int subjectId { get; set; }
        public Subject Subject { get; set; }




    }
}
