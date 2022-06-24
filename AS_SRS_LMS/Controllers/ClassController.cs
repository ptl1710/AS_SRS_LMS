using AS_SRS_LMS.Interface;
using AS_SRS_LMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly IClass _class;
        public ClassController(IClass cla)
        {
            _class = cla;
        }
        [HttpGet("get-all-class")]
        public ActionResult<IEnumerable<Class>> GetAllClass()
        {
            var cla = _class.GetAllClass();
            return Ok(cla);
        }
        [HttpPost("create-class")]
        public IActionResult CreateClass(ClassRequest request)
        {
            _class.AddClass(request);
            return Ok(new { message = "Tạo Thành Công!!!" });
        }
        [HttpGet("detail-class")]
        public IActionResult DetailClass(string id)
        {
            var sub = _class.DetailClass(id);
            return Ok(sub);
        }
        [HttpGet("delete-class")]
        public IActionResult DeleteClass(string id)
        {
            _class.RemoveClass(id);
            return Ok(new { message = "Xóa Thành Công!!!" });
        }
        [HttpPut("update-class")]
        public IActionResult UpdateSub(string id, ClassRequest request)
        {
            var cla = _class.DetailClass(id);
            if (id == null)
            {
                return BadRequest("Vui Lòng Nhập Id Môn Học");
            }
            if (cla == null)
            {
                return BadRequest("Không Tìm Thấy Môn Học");
            }
            _class.UpdateClass(id, request);
            return Ok(new { message = "Cập Nhật Thành Công" });
        }
    }
}
