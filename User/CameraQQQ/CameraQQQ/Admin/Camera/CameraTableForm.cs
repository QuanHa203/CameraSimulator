using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraQQQ.Admin.Camera
{
    public partial class CameraTableForm : Form
    {
        public CameraTableForm()
        {
            InitializeComponent();
        }

        private void labelCreateCamera_Click(object sender, EventArgs e)
        {
            new CreateCameraForm().Show();
        }
    }
}
