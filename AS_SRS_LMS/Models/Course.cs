using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string idCourse { get; set; }
        public string themeCourse { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool  Status { get; set; }
        public float Time { get; set; }
        public string Unit { get; set; }
        public List<detailCourse> detailCourses { get; set; }
        public List<detailSubject> detailSubjects { get; set; }
    }
}
