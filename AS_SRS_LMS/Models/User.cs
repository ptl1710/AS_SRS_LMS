using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string Email { get; set; }
        public string firstName { get; set; }
        public int lastName { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public bool IsEmailConfirmed { get; set; }


        public int roleId { get; set; }
        public Role role { get; set; }
        public int classId { get; set; }
        public Class Class { get; set; }



    }
}
