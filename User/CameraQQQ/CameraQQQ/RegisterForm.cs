using CameraQQQ.Models;
using CameraQQQ.Services;
using Newtonsoft.Json;
using System.Text;

namespace Register
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        private void RegisterUser()
        {
            var url = "/api/RegisterUser/register";
            var user = new User
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                IdRole = int.Parse(txtRole.Text)
            };

            var json = JsonConvert.SerializeObject(user);            
            var response = SendRequestToServer.SendRequest(HttpMethod.Post, url, json);
                                    
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Đăng ký thành công");
            }
            else
            {
                MessageBox.Show(response.Data);
            }
        }
    }
}
