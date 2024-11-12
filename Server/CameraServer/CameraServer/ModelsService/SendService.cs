using CameraServer.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;
using MimeKit;

namespace CameraServer.ModelsService
{
    public class SendService : ISendMailService
    {
        MailSettings mailSettings;
        CameraSimulatorContext _context;
        public SendService(IOptions<MailSettings> option, CameraSimulatorContext context) { 
            mailSettings = option.Value;
            _context = context;
        }

        public bool SendMail(string email)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                throw new Exception("Khong thay User");
            }

            try
            {
                var newPassword = new Random().Next(100000000, 999999999).ToString();
                user.Password = newPassword;
                _context.SaveChanges(); 

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(mailSettings.DisplayName, mailSettings.HostMail));
                message.To.Add(new MailboxAddress(user.UserName, user.Email));
                message.Subject = "Yêu cầu reset lại mật khẩu";

                var bodyBuilder = new BodyBuilder { TextBody = $"\n\nMật khẩu reset của bạn là: {newPassword}" };
                message.Body = bodyBuilder.ToMessageBody();

                using (var smtp = new SmtpClient())
                {
                    smtp.Connect(mailSettings.Host, mailSettings.Port, SecureSocketOptions.StartTls);
                    smtp.Authenticate(mailSettings.HostMail, mailSettings.Password);
                    smtp.Send(message);
                    smtp.Disconnect(true);
                }

                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
