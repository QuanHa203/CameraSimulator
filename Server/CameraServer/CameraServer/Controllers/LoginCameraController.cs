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
        public IActionResult LoginCamera([FromBody] Camera camera) {
           
            var checkCam = _context.Cameras.Any(cam => cam.CameraName == camera.CameraName);
            if (!checkCam) { return BadRequest("Tên đăng nhập Camera không chính xác!."); }

            var checkCode = _context.Cameras.Any(code => code.ConnectionCode == camera.ConnectionCode);
            if (!checkCode) { return BadRequest("Code kết nối không chính xác!"); }

            var checkPassWord = _context.Cameras.Any(pass => pass.Password == camera.Password);
            if (!checkPassWord) { return BadRequest("Mật khẩu không trùng khớp!"); }

            return Ok("Kết nối Camera thành công!");
        }
    }
}
