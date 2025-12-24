using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppLayerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        DepartmentService service;
        public DepartmentController(DepartmentService service) { 
            this.service = service;
        }
        [HttpGet("all")]
        public IActionResult All() {
            var data = service.All();
            return Ok(data);
        }
    }
}
