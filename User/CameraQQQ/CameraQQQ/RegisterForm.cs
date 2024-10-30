using CameraQQQ;
using Newtonsoft.Json;
using System.Text;

namespace Register
{
    public partial class RegisterForm : Form
    {
        private User user = null;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            await RegisterUser();
        }

        private async Task RegisterUser()
        {
            using (var httpClient = new HttpClient())
            {
                var url = "https://localhost:7268/api/RegisterUser/register";

                var user = new User
                {
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    IdRole = int.Parse(txtRole.Text)
                };

                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync(url, content);
                    response.EnsureSuccessStatusCode();
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
