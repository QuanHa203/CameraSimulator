
using CameraQQQ.Services;
using System.Drawing.Drawing2D;

namespace CameraQQQ.Client
{
    public partial class CameraInfo : Form
    {
        public string CameraName { get; set; } = "";
        public string ConnectionCode { get; set; } = "";

        public CameraInfo()
        {
            InitializeComponent();

            // Đặt TransparencyKey để loại bỏ nền xung quanh góc bo
            this.TransparencyKey = Color.Fuchsia; // Màu để làm trong suốt            
        }

        private void pictureBoxPlay_Click(object sender, EventArgs e)
        {
            new WatchCameraForm(ConnectionCode).ShowDialog();
        }

        private void CameraInfo_Load(object sender, EventArgs e)
        {
            labelCameraName.Text = CameraName;

            int cornerRadius = 24;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90);
            path.AddLine(cornerRadius, 0, this.Width - cornerRadius, 0);
            path.AddArc(new Rectangle(this.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90);
            path.AddLine(this.Width, cornerRadius, this.Width, this.Height - cornerRadius);
            path.AddArc(new Rectangle(this.Width - cornerRadius, this.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90);
            path.AddLine(this.Width - cornerRadius, this.Height, cornerRadius, this.Height);
            path.AddArc(new Rectangle(0, this.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90);
            path.AddLine(0, this.Height - cornerRadius, 0, cornerRadius);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void pictureBoxDeleteCamera_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có muốn xóa camera này không?", "Xóa camera", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string path = $"ConnectionCamera?connectionCode={ConnectionCode}&userName={LoginForm.User.UserName}";
                var response = SendRequestToServer.SendRequest(HttpMethod.Delete, path);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(response.Data);
                    foreach (var camera in LoginForm.User.Cameras!)
                    {
                        if(camera.CameraName.Trim() == CameraName)
                        {
                            LoginForm.User.Cameras.Remove(camera);
                            break;
                        }
                    }

                    HomeForm.AddFormToPanel(new CameraListForm());
                }
                else
                {
                    MessageBox.Show(response.Data);
                }
            }
        }
    }
}
