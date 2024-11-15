using CameraServer.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CameraServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterUserController : ControllerBase
    {
        private readonly CameraSimulatorContext _context;

        public RegisterUserController(CameraSimulatorContext context)
        {
            _context = context;
        }
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterUser user)
        {
            User newUser = new User
            {
                IdRole = 2,
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email,
                IsBan = false
            };

            var checkRole = _context.Roles.Any(role => role.Id == newUser.IdRole);
            if (!checkRole) { return BadRequest("Không tìm thấy IdRole!"); }

            var checkName = _context.Users.Any(name => name.UserName.Trim() == newUser.UserName.Trim());
            if (checkName) { return BadRequest("Tên đăng nhập đã được sử dụng!"); }

            var checkEmail = _context.Users.Any(email => email.Email == newUser.Email);
            if (checkEmail) { return BadRequest("Email đã được sử dụng!"); }

            _context.Users.Add(newUser);
            _context.SaveChanges();

            return Ok(newUser);
        }

        public class RegisterUser
        {
            [StringLength(100)]
            public string UserName { get; set; } = null!;

            [StringLength(100)]
            public string Password { get; set; } = null!;

            [StringLength(100)]
            public string Email { get; set; } = null!;
        }
    }
}