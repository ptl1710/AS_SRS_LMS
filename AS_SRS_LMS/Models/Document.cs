using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AS_SRS_LMS.Models
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string documentId { get; set; }
        public string Link { get; set; }
        public int subjectId { get; set; }
        public Subject Subject { get; set; }
    }
}
