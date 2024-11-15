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
            List<User> users = _context.Users.ToList();
            User user = users.FirstOrDefault(u => u.UserName == username.Trim() && u.Password == password.Trim());
            if (user == null)
                return BadRequest("Sai tài khoản hoặc mật khẩu");

            CameraUser cameraUser = _context.CameraUsers.Include(cU => cU.IdCameraNavigation).FirstOrDefault(cU => cU.IdUser == user.Id);
            if (cameraUser == null)
            {
                return Ok(new
                {
                    IdRole = user.IdRole,
                    UserName = user.UserName,
                    Email = user.Email,
                    IsBan = user.IsBan,
                });
            }

            var body = new
            {
                IdRole = user.IdRole,
                UserName = user.UserName,
                Email = user.Email,
                IsBan = user.IsBan,
                ConnectionCode = cameraUser.IdCameraNavigation.ConnectionCode
            };
            return Ok(body);

        }
    }
}
