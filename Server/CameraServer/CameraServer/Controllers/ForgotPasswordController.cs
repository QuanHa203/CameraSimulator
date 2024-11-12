using CameraServer.Models;
using CameraServer.ModelsService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Identity.Client;

namespace CameraServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        private readonly CameraSimulatorContext _context;

        private readonly ISendMailService _sendMailService;

        public ForgotPasswordController(CameraSimulatorContext context, ISendMailService sendMailService) {
            _context = context;
            _sendMailService = sendMailService;
        }

        [HttpPost]
        public IActionResult ForgotPass(string email) {
            
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null) { 
                return NotFound("Không tìm thấy Email");
            }

            if (user.IdRole == 1)
            {
                return BadRequest("Không thể reset mật khẩu cho Admin");
            }
            else 
            {
                bool isMailSent = _sendMailService.SendMail(email);

                if (isMailSent)
                {
                    return Ok("Reset mật khẩu thành công!.");
                }
                else
                {
                    return BadRequest("Reset mật khẩu không thành công.");
                }
            }
        }
    }
}
