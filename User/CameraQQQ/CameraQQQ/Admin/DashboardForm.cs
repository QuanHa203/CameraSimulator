using CameraQQQ.Admin.Camera;
using CameraQQQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraQQQ.Admin
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            panelRef = panelShow;
        }
        private static Panel panelRef;
        public static void AddFormToPanel(Form f)
        {
            f.TopLevel = false;
            panelRef.Controls.Clear();
            panelRef.Controls.Add(f);
            f.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelCamera_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new CameraTableForm());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
