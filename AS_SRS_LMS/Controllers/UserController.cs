using AS_SRS_LMS.Interface;
using AS_SRS_LMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        [HttpGet("get-all-user")]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _user.GetAllUser();
            return Ok(users);
        }
        [HttpPost("register")]
        public  IActionResult Register(UserRegisterRequest request)
        {
            
            int register =_user.Register(request);
            if(register == 0)
            {
                return BadRequest(new { message = "Người Dùng Đã Tồn Tại!!!" });
            }
            return Ok(new { message = "Tạo Thành Công!!!" });
        }
        [HttpPost("login")]
        public IActionResult Login(UserLoginRequest request)
        {
            int login = _user.Login(request);
            if (login == 0)
            {
                return BadRequest(new { message = "Tên Đăng Nhập Hoặc Mật Khẩu Không Chính Xác!!!" });
            }
            return Ok(new { message = "Đăng Nhập Thành Công" });
        }
        [HttpPost("forgot-password")]
        public IActionResult Forgot(string email, string phone, string newpass)
        {

            int forgot = _user.ForgotPassword(email, phone, newpass);
            if (forgot == 0)
            {
                return BadRequest(new { message = "Tài Khoản Không Tồn Tại!!!" });
            }
            return Ok(new { message = "Đổi Mật Khẩu Thành Công!!!" });
        }

    }
}
