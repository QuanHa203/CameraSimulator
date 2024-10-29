using CameraServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Data.SqlClient;

namespace CameraServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginUserController : ControllerBase
    {
        private  CameraSimulatorContext _context;
        public LoginUserController(CameraSimulatorContext context)
        {
            _context = context;
         
        }

        [HttpPost (Name = "PostLogin")]
        public IActionResult Login(string username, string password)
        {
            List<User> users = _context.Users.ToList();
            User user = users.FirstOrDefault(u => u.UserName == username.Trim() && u.Password == password.Trim());
            if (user == null) 
                return BadRequest("Sai tài khoản hoặc mật khẩu");
            
            Guid cookie = Guid.NewGuid();
            Response.Cookies.Append("Cookie-value", cookie.ToString());

            var body = new
            {
                IdRole = user.IdRole,
                UserName = user.UserName,
                Email = user.Email,
                IsBan = user.IsBan        
            };
            return Ok(body);
           
        }
    }
}
