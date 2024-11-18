using CameraQQQ.Admin.Camera;
using CameraQQQ.Admin.User;

namespace CameraQQQ.Admin
{
    public partial class DashboardForm : Form
    {
        private static Panel panelRef = null!;
        public DashboardForm()
        {
            InitializeComponent();
            panelRef = panelShow;
        }

        public static void AddFormToPanel(Form f)
        {
            f.TopLevel = false;
            panelRef.Controls.Clear();
            panelRef.Controls.Add(f);
            f.Show();
        }

        private void OpenCameraTable_Click(object sender, EventArgs e)
        => AddFormToPanel(new CameraTableForm());

        private void OpenUserTable_Click(object sender, EventArgs e)
        => AddFormToPanel(new UserTableForm());

        private void Exit_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                this.Close();
        }
    }
}
