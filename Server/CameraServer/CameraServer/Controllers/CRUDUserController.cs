using CameraServer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CameraServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CRUDUserController : ControllerBase
    {
        private readonly CameraSimulatorContext _context;
        public CRUDUserController(CameraSimulatorContext context)
        {
            _context = context;
        }

        [HttpGet("UserList")]
        public IActionResult GetUserList()
        {
            return Ok(_context.Users.ToList());
        }

        // Them nguoi dung
        [HttpPost("CreateUser")]
        public IActionResult CreateUser(string username, string password, string email)
        {
            var newUser = new User
            {
                IdRole = 2,
                IsBan = false,
                UserName = username,
                Email = email,
                Password = password
            };
            var checkName = _context.Users.Any(name => name.UserName == newUser.UserName);
            if (checkName) { return BadRequest("Tên người dùng này đã được sử dụng!"); }
            var checkEmail = _context.Users.Any(mail => mail.Email == newUser.Email);
            if (checkEmail) { return BadRequest("Email này đã được đăng ký!"); }
            _context.Users.Add(newUser);
            _context.SaveChanges();
            return Ok(newUser);
        }

        // Cap nhat nguoi dung
        [HttpPatch("UpdateUser")]
        public IActionResult UpdateUser(int id, string name, string password, string email, bool isBan)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return BadRequest("Không tìm thấy Id người dùng");
            }

            var checkName = _context.Users.Any(u => u.Id != id && u.UserName == name);
            if (checkName) { return BadRequest("Tên người dùng này đã được sử dụng!"); }

            var checkEmail = _context.Users.Any(u => u.Id != id && u.Email == email);
            if (checkEmail) { return BadRequest("Email này đã được đăng ký!"); }

            user.UserName = name;
            user.Password = password;
            user.Email = email;
            user.IsBan = isBan;

            _context.SaveChanges();
            return Ok(user);
        }

        // Xoa nguoi dung
        [HttpDelete("DeleteUser")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                return BadRequest("Id người dùng không tồn tại");
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
            return Ok("Xóa thành công");
        }
    }
}
