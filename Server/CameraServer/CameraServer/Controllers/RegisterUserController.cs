using CameraServer.Models;
using CameraServer.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;

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
                IdRole = user.IdRole,
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email,
                IsBan = user.IsBan,
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

            public int IdRole { get; set; }

            [StringLength(100)]
            public string UserName { get; set; } = null!;

            [StringLength(100)]
            public string Password { get; set; } = null!;

            [StringLength(100)]
            public string Email { get; set; } = null!;

            public bool? IsBan { get; set; }
        }
    }
}
