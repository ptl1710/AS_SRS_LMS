using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ClassId { get; set; }
        public string NameClass { get; set; }
        public string? Link { get; set; }
        public string Amount { get; set; }
        public bool? Status { get; set; }
        //public int IdSubject { get; set; }
        public Subject subject { get; set; }
        public List<User> users { get; set; }




    }
}
