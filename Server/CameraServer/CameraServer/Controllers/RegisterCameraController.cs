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
        [HttpPost("RegisterCamera")]
        public IActionResult RegisterCamera(string cameraName , string password)
        {
            if(string.IsNullOrEmpty(cameraName)) 
                return BadRequest();
            if (string.IsNullOrEmpty(password))
                return BadRequest();

            Camera newCamera = new Camera
            {
                CameraName = cameraName,
                Password = password,
                ConnectionCode = new Random().Next(100000000,999999999).ToString(),
            };
            
            
            var checkName = _context.Cameras.Any(name => name.CameraName.Trim() == newCamera.CameraName.Trim());
            if (checkName) { return BadRequest("Tên camera đã được sử dụng!"); }
            _context.Cameras.Add(newCamera);
            _context.SaveChanges();
            return Ok(new
            {
                ConnectionCode = newCamera.ConnectionCode
            });
        }
    }
}
