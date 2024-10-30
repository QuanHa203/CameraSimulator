using CameraServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CameraServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterCameraController : ControllerBase
    {
        private CameraSimulatorContext _context;
        public RegisterCameraController(CameraSimulatorContext context)
        {
            _context = context;
        }
        [HttpPut("AddCamera")]
        public IActionResult AddCamera(Camera cam)
        {
            if(string.IsNullOrEmpty(cam.CameraName)) 
                return BadRequest();
            if (string.IsNullOrEmpty(cam.Password))
                return BadRequest();
            if (string.IsNullOrEmpty(cam.ConnectionCode))
                return BadRequest();
            
            Camera newCamera = new Camera
            {               
                CameraName = cam.CameraName,
                Password = cam.Password,
                ConnectionCode = cam.ConnectionCode,
            };
            var checkName = _context.Cameras.Any(name => name.CameraName.Trim() == newCamera.CameraName.Trim());
            if (checkName) { return BadRequest("Tên camera đã được sử dụng!"); }

            var checkConnection = _context.Cameras.Any(connection => connection.ConnectionCode == newCamera.ConnectionCode.Trim());
            if (checkConnection) { return BadRequest("Mã kết nối đã được sử dụng!"); }

            _context.Cameras.Add(newCamera);
            _context.SaveChanges();

            return Ok(cam);
        }
       
    }
}
