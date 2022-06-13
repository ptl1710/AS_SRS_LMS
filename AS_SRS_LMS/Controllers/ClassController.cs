using AS_SRS_LMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly DataContext _context;

        public ClassController(DataContext context)
        {
            _context = context;
        }
        [HttpPost("create-class")]
        public async Task<IActionResult> Register(ClassAddRequest request)
        {
            if (_context.Class.Any(u => u.className == request.className))
            {
                return BadRequest("Lớp Học Đã Tồn Tại");
            }

            var cla = new Class
            {
                className = request.className,
                startDate = request.startDate,
                endDate = request.endDate,
                subjectId = request.subjectId,

            };
            _context.Class.Add(cla);
            await _context.SaveChangesAsync();
            return Ok("Tạo Lớp Học Thành Công");
        }
    }
}
