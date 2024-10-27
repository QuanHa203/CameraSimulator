using CameraServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Data.SqlClient;

namespace CameraServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private  CameraSimulatorContext _context;
        public LoginController(CameraSimulatorContext context)
        {
            _context = context;
         
        }
        [HttpGet (Name ="GetUsers")]
        public IActionResult GetUsers()
        {
            List<User> users = _context.Users.ToList();
            return Ok (users);
        }
        [HttpPost (Name = "PostLogin")]
        public IActionResult Login(string username, string password)
        {
            List<User> users = _context.Users.ToList();
            User user = users.FirstOrDefault(u => u.UserName == username.Trim() && u.Password == password.Trim());
            if (user == null) 
                return BadRequest("Sai tài khoản hoặc mật khẩu");
            var body = new
            {
                IdRole = user.IdRole,
                UserName = user.UserName
            };
            return Ok(body);
        }


      
        
        

    }
}
