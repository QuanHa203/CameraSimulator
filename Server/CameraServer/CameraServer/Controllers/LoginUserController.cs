using CameraServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace CameraServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginUserController : ControllerBase
    {
        private CameraSimulatorContext _context;
        public LoginUserController(CameraSimulatorContext context)
        {
            _context = context;

        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            List<User> users = _context.Users.Include(u => u.IdCameras).ToList();
            User? user = users.FirstOrDefault(u => u.UserName == username.Trim() && u.Password == password.Trim());

            if (user == null)
                return BadRequest("Sai tài khoản hoặc mật khẩu");

            var body = new
            {
                IdRole = user.IdRole,
                UserName = user.UserName,
                Email = user.Email,
                IsBan = user.IsBan,
                Cameras = user.IdCameras.Select(select => new { CameraName = select.CameraName, ConnectionCode = select.ConnectionCode})
            };
            return Ok(body);

        }
    }
}
