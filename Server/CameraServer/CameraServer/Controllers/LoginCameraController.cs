using CameraServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CameraServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginCameraController : ControllerBase
    {
        private readonly CameraSimulatorContext _context;

        public LoginCameraController (CameraSimulatorContext context)
        {
            _context = context;
        }

        [HttpPost("login")] 
        public IActionResult LoginCamera(string cameraName, string password) {
            var camera = _context.Cameras.FirstOrDefault(cam => cam.CameraName == cameraName && cam.Password == password);

            if (camera == null)
                return BadRequest("Tên đăng nhập hoặc mật khẩu không chính xác");

            return Ok(new
            {
                CameraName = camera?.CameraName,
                ConnectionCode = camera?.ConnectionCode,
            });
        }
    }
}
