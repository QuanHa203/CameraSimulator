using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraQQQ.Client
{
    public partial class CameraListForm : Form
    {
        public CameraListForm()
        {
            InitializeComponent();

            foreach (var camera in LoginForm.User.Cameras)
            {
                CameraInfo cameraForm = new CameraInfo()
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Width = flowLayoutPanelCameraList.Width - 30,
                    CameraName = camera.CameraName.Trim(),
                    ConnectionCode = camera.ConnectionCode.Trim(),
                };
                
                cameraForm.Show();
                flowLayoutPanelCameraList.Controls.Add(cameraForm);
            }

        }
    }
}
