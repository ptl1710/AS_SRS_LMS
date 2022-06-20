using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AS_SRS_LMS.Models
{
    public class Document
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DocumentId { get; set; }
        public int NameDocument { get; set; }
        public string Link { get; set; }
        public int IdSubject { get; set; }
        public Subject subject { get; set; }
    }
}
