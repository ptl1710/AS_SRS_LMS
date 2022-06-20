using AS_SRS_LMS.Models;
using System.Security.Cryptography;

namespace AS_SRS_LMS.Interface
{
    public interface IUser
    {
        List<User> GetAllUser();
        int Register(UserRegisterRequest request);
        int Login(UserLoginRequest request);
        void Verify(string token);
        int ForgotPassword(string email, string phone, string newpass);
        

    }
    public class UserManager:IUser
    {
        private readonly DataContext _context;
        public UserManager(DataContext context)
        {
            _context = context;
        }
        public int ForgotPassword(string email, string phone, string newpass)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.PhoneNumber == phone);
            if (user == null)
            {
                return 0;
            }
            else
            {
                user.Password = HashPassword.Encrypt(newpass);
                _context.Users.Update(user);
                _context.SaveChanges();
                return 1;
            }
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList(); ;
        }

        public int Login(UserLoginRequest request)
        {
           var user = _context.Users.FirstOrDefault(u => u.Email == request.Email && u.Password == request.Password);
            if (user == null)
            {
                return 0;

            }
            else
            {
                return 1;
            }
        }

        public int Register(UserRegisterRequest request)
        {
            if (_context.Users.Any(u => u.Email == request.Email))
            {
                return 0;
            }
            else
            {
                var user = new User
                {
                    Email = request.Email,
                    Password =HashPassword.Encrypt( request.Password),
                    PhoneNumber = request.PhoneNumber,
                    RoleId = request.RoleId,

                };
                _context.Users.Add(user);
                _context.SaveChanges();
                return 1;
            }
            
        }
        


        public void Verify(string token)
        {
            throw new NotImplementedException();
        }
    }
    
}

