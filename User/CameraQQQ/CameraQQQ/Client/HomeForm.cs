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
    public partial class HomeForm : Form
    {
        private static Panel panelRef;
        public HomeForm()
        {
            InitializeComponent();
            panelRef = panelShow;
            labelUserName.Text = LoginForm.User.UserName;
            AddFormToPanel(new CameraListForm());
        }
        public static void AddFormToPanel(Form f)
        {
            f.TopLevel = false;
            panelRef.Controls.Clear();
            panelRef.Controls.Add(f);
            f.Show();
        }

        private void OpenCameraListForm_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new CameraListForm());
        }

        private void OpenAddCameraForm_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new AddCameraForm());
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 0x1;
            const int HTCAPTION = 0x2;

            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && m.Result == (IntPtr)HTCLIENT)
            {
                m.Result = (IntPtr)HTCAPTION; // Cho phép kéo cửa sổ
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
