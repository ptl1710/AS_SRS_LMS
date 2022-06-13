using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AS_SRS_LMS.Models
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int roleId { get; set; }
        public string roleName { get; set; }
        public string Status { get; set; }


        public List<User> User { get; set; }
    }
}
