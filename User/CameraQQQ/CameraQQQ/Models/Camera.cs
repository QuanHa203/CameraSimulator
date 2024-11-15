using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraQQQ.Models
{
    public class Camera
    {
        public int Id { get; set; }
        public string CameraName { get; set; } = "";
        public string Password { get; set; } = "";
        public string ConnectionCode { get; set; } = "";
    }
}
