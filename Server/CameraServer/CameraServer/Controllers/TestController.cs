using CameraServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CameraServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly CameraSimulatorContext _context;
        public TestController(CameraSimulatorContext context) 
        {
            _context = context;
        }
        [HttpGet("UserList")]
        public IActionResult GetUserList()
        {
            return Ok(_context.Users.ToList());
        }
    }
}
