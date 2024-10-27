using CameraServer.Data;
using CameraServer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CameraServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterUserAPIController : ControllerBase
    {
        private readonly CameraSimulatorContext _context;

        public RegisterUserAPIController(CameraSimulatorContext context) {
            _context = context;
        }

        [HttpGet("GetList")]
        public IActionResult GetUser()
        {
            var user = _context.Users.ToList();
            return Ok(user);
        }

        [HttpPost("userRegister")]
        public IActionResult Register([FromBody] RegisterUser user)
        {
            User newUser = new User
            {
                IdRole = user.IdRole,
                IdVideo = user.IdVideo,
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email,
                IsBan = user.IsBan,
            };


            var checkRole = _context.Roles.Any(role => role.Id == newUser.IdRole);
            if (!checkRole)
            {
                return BadRequest("Không thấy IDRole!.");
            }

            var checkName = _context.Users.Any(name => name.UserName.Trim() == newUser.UserName.Trim());
            if (checkName)
            {
                return BadRequest("Tên đăng nhập đã được sử dụng!.");
            }

            var checkEmail = _context.Users.Any(email => email.Email == newUser.Email);
            if (checkEmail)
            {
                return BadRequest("Email đã được sử dụng.");
            }

            /*var checkIdVideo = _context.Videos.Any(video => video.Id == newUser.IdVideo);
            if (!checkIdVideo)
            {
                return BadRequest();
            }*/

            _context.Users.Add(newUser);
            _context.SaveChanges();
            return Ok(newUser);
        }
        public class RegisterUser {

            public int IdRole { get; set; }

            public int? IdVideo { get; set; }

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
