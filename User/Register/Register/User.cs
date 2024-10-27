using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Register
{
    public class User
    {

        public int IdRole { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; } 
    }
}