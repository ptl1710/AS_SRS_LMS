using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AS_SRS_LMS.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string QuestionId { get; set; }
        public string Form { get; set; }
        public int IdSubject { get; set; }
        public Subject subject { get; set; }
    }
}
