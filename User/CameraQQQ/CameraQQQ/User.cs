using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraQQQ
{
    public class User
    {
        public int IdRole { get; set; }
        public string UserName { get; set; }
        public string? Password { get; set; }
        public string Email { get; set; }
        public bool IsBan { get; set; }
        public string Cookie { get; set; }
    }
}
