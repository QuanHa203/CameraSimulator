using Azure.Core;
using CameraServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CameraServer.Services
{
    public class GetStatusCodeByCookie
    {
        public static HttpStatusCode GetStatusCode(string? cookie, CameraSimulatorContext context)
        {            
            if (cookie == null)
                return HttpStatusCode.BadRequest;

            User user = context.Users.FirstOrDefault(u => u.Cookie == cookie);

            if(user == null)    
                return HttpStatusCode.BadRequest;

            int idRole = user.IdRole;
            if (idRole != 1)
                return HttpStatusCode.BadRequest;

            return HttpStatusCode.OK;
        }
    }
}
