using AS_SRS_LMS.Interface;
using AS_SRS_LMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AS_SRS_LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly ISub _sub;
        public SubjectController(ISub sub)
        {
            _sub = sub;
        }
        [HttpGet("get-all-subject")]
        public ActionResult<IEnumerable<Subject>> GetAllSubject()
        {
            var sub = _sub.GetAllSub();
            return Ok(sub);
        }
        [HttpPost("create-subject")]
        public IActionResult CreateSub(SubjectRequest request)
        {
           _sub.AddSub(request);
            return Ok(new { message = "Tạo Thành Công!!!" });
        }
        [HttpGet("detail-subject")]
        public IActionResult DetailSub(string id)
        {
            var sub = _sub.DetailSub(id);
            return Ok(sub);
        }
        [HttpGet("delete-subject")]
        public IActionResult DeleteSub(string id)
        {
            _sub.RemoveSub(id);
            return Ok(new { message = "Xóa Thành Công!!!" });
        }
        [HttpPut("Update-subject")]
        public IActionResult UpdateSub(string id, SubjectRequest request)
        {
            var sub = _sub.DetailSub(id);
            if(id == null)
            {
                return BadRequest("Vui Lòng Nhập Id Môn Học");
            }
            if(sub == null)
            {
                return BadRequest("Không Tìm Thấy Môn Học");
            }    
            _sub.UpdateSub(id, request);
            return Ok(new { message = "Cập Nhật Thành Công" });
        }

    }
}
