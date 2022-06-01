using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string idClass { get; set; }
        public string nameClass { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
        
        public List<User> Users { get; set; } 
        public string UserId { get; set; }
        
    }
}
