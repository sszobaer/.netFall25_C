using IntroEFDBFAPICore.EF;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntroEFDBFAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        Fall25CContext db;
        //receiving the injected object
        public DepartmentController(Fall25CContext db) { 
            this.db = db;
        }
        [HttpGet("all")]
        public IActionResult All() {
            var data = db.Departments.ToList();
            return Ok(data);
        }
    }
}
