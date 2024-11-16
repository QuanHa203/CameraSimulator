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
        public HomeForm()
        {
            InitializeComponent();
        }
        private void AddFormToPanel(Form f)
        {
            f.TopLevel = false;
            pnlShow.Controls.Clear();
            pnlShow.Controls.Add(f);
            f.Show();

        }

        private void panelAddCamera_Click(object sender, EventArgs e)
        {

        }

        private void panelWatchCamera_Click(object sender, EventArgs e)
        {
            AddFormToPanel(new WatchCameraForm());
        }

        private void panelLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
