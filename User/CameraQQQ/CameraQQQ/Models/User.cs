using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraQQQ.Models
{
    public class User
    {
        public int Id { get; set; }

        public int IdRole { get; set; }

        public int? IdVideo { get; set; }

        public string UserName { get; set; } = "";

        public string? Password { get; set; }

        public string Email { get; set; } = "";

        public bool IsBan { get; set; }

        public ICollection<CameraQQQ.Models.Camera>? Cameras { get; set; } = new List<CameraQQQ.Models.Camera>();
    }
}
