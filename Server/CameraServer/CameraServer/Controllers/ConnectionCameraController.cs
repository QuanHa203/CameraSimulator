using CameraServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CameraServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConnectionCameraController : ControllerBase
    {
        private readonly CameraSimulatorContext _context;
        public ConnectionCameraController(CameraSimulatorContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AddCamera(string connectionCode, string userName)
        {
            var camera = _context.Cameras.Include(cam => cam.IdUsers).FirstOrDefault(cam => cam.ConnectionCode == connectionCode);
            if (camera == null)
                return NotFound("Không có camera nào có mã kết nối này!");

            var user = _context.Users.Include(u => u.IdCameras).FirstOrDefault(u => u.UserName.Trim() == userName.Trim());

            if (user == null)
                return NotFound("Không có UserName này!");

            var isConnect = user.IdCameras.FirstOrDefault(c => c.ConnectionCode.Trim() == connectionCode.Trim());

            if (isConnect != null)
                return BadRequest("Người dùng đã kết nối với camera này rồi!");


            
            camera.IdUsers.Add(user);
            _context.SaveChanges();
            return Ok(new
            {
                CameraName = camera.CameraName,
                ConnectionCode = camera.ConnectionCode
            });
        }

        [HttpDelete]
        public IActionResult DeleteCamera(string connectionCode, string userName)
        {
            var camera = _context.Cameras.FirstOrDefault(cam => cam.ConnectionCode == connectionCode);
            if (camera == null)
                return NotFound("Không có camera nào có mã kết nối này!");

            var user = _context.Users.Include(u => u.IdCameras).FirstOrDefault(u => u.UserName.Trim() == userName.Trim());
            if (user == null)
                return NotFound("Không có UserName này!");

            var isConnect = user.IdCameras.FirstOrDefault(c => c.ConnectionCode.Trim() == connectionCode.Trim());

            if (isConnect == null)
                return BadRequest("Người dùng chưa kết nối với camera này!");

            user.IdCameras.Remove(isConnect);
            _context.SaveChanges();
            return Ok("Hủy kết nối tới camera thành công!");
        }
    }
}
