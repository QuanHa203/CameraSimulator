using CameraServer.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CameraServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CameraController : ControllerBase
    {
        private CameraSimulatorContext _context;
        public CameraController(CameraSimulatorContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult GetAllCamera()
        {
            var allCamera = _context.Cameras.ToList();
            return Ok(allCamera);
        }
        [HttpPost]
        public IActionResult AddCamera([FromBody] NewCamera camera)
        {
            Camera newCamera = new Camera
            {
                CameraName = camera.CameraName,
                Password = camera.Password,
                ConnectionCode = camera.ConnectionCode,
            };
            var checkName = _context.Cameras.Any(name => name.CameraName.Trim() == newCamera.CameraName.Trim());
            if (checkName) { return BadRequest("Tên camera đã được sử dụng!"); }
            var checkConectionCode = _context.Cameras.Any(name => name.ConnectionCode.Trim() == newCamera.ConnectionCode.Trim());
            if (checkConectionCode) { return BadRequest("Mã kết nối đã được sư dụng!"); }
            _context.Cameras.Add(newCamera);
            _context.SaveChanges();
            return Ok(newCamera);

        }
        [HttpPut]
        public IActionResult EditCamera([FromBody] Camera editcamera)
        {
            if (editcamera == null)
            {
                return BadRequest("Dữ liệu không hợp lệ.");
            }

            var camera = _context.Cameras.SingleOrDefault(c => c.Id == editcamera.Id);
            if (camera == null)
            {
                return NotFound("Camera không tồn tại.");
            }
            var isDuplicateName = _context.Cameras.Any(c => c.Id != editcamera.Id && c.CameraName.Trim() == editcamera.CameraName.Trim());
            if (isDuplicateName)
            {
                return BadRequest("Tên camera đã được sử dụng!");
            }
            var isDuplicateConnectionCode = _context.Cameras.Any(c => c.Id != editcamera.Id && c.ConnectionCode.Trim() == editcamera.ConnectionCode.Trim());
            if (isDuplicateConnectionCode)
            {
                return BadRequest("Mã kết nối đã được sử dụng!");
            }
            camera.CameraName = editcamera.CameraName;
            camera.Password = editcamera.Password;
            camera.ConnectionCode = editcamera.ConnectionCode;

            _context.SaveChanges();
            return Ok(camera);
        }
        [HttpDelete]
        public IActionResult DeleteCamera(int Id)
        {
            var camera = _context.Cameras.Find(Id);
            if (camera == null)
            {
                return BadRequest();
            }
            _context.Cameras.Remove(camera);
            _context.SaveChanges();
            return Ok();
        }
        public class NewCamera()
        {
            [StringLength(100)]
            public string CameraName { get; set; } = null!;

            [StringLength(100)]
            public string Password { get; set; } = null!;

            [StringLength(10)]
            public string ConnectionCode { get; set; } = null!;
        }

    }
}
