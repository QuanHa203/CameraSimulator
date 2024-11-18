using CameraQQQ.Admin;
using CameraQQQ.Client;
using CameraQQQ.Models;
using CameraQQQ.Services;
using Newtonsoft.Json;
using Register;
using System.Net;
using System.Text;

namespace CameraQQQ
{

    public partial class LoginForm : Form
    {
        public static User User { get; set; } = null!;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string url = $"LoginUser?username={userName}&password={password}";

            var rs= SendRequestToServer.SendRequest(HttpMethod.Post, url);            

            var response = SendRequestToServer.SendRequest(HttpMethod.Post, url);
            string data = response.Data;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                User = JsonConvert.DeserializeObject<User>(data)!;
                MessageBox.Show("Đăng nhập thành công");

                if (User.IdRole == 1)
                {
                    MessageBox.Show("Chào mừng admin");
                    this.Hide();
                    new DashboardForm().ShowDialog();
                    this.Close();
                }
                else if (User.IdRole == 2)
                {
                    MessageBox.Show("Chào mừng user");
                    this.Hide();
                    new HomeForm().ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(data);
            }
        }

        private void lbAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().ShowDialog();
            this.Show();
        }

        private void Forgot_Click(object sender, EventArgs e)
        {
            new ForgotPasswordUser().Show();
            this.Close();
        }
    }
}
