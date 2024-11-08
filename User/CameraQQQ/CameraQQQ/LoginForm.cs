using CameraQQQ.Admin;
using CameraQQQ.Client;
using CameraQQQ.Models;
using Newtonsoft.Json;
using Register;
using System.Net;
using System.Text;

namespace CameraQQQ
{

    public partial class LoginForm : Form
    {
        public static User userLogin = new User()
        {
            UserName = "HaQuan",
            ConnectionCode = "111111111"
        };
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
            string url = $"https://localhost:7268/LoginUser?username={userName}&password={password}";

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.Method = HttpMethod.Post;
                    using (HttpResponseMessage httpResponseMessage = client.Send(httpRequestMessage))
                    {
                        string data = "";
                        HttpContent httpContent = httpResponseMessage.Content;
                        using (Stream stream = httpContent.ReadAsStream())
                        {
                            byte[] buffer = new byte[stream.Length];
                            stream.Read(buffer, 0, buffer.Length);
                            data = Encoding.UTF8.GetString(buffer);

                            if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                            {
                                userLogin = JsonConvert.DeserializeObject<User>(data);
                                MessageBox.Show("Đăng nhập thành công");
                                if (userLogin.IdRole == 1)
                                {

                                    MessageBox.Show("Chào mừng admin");
                                    new DashboardForm().Show();
                                    this.Close();

                                }
                                else if (userLogin.IdRole == 2)
                                {
                                    MessageBox.Show("Chào mừng user");
                                    new HomeForm().Show();
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show(data);
                            }
                        }

                    }
                }

            }
        }

        private void lbAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterForm().ShowDialog();
            this.Show();
        }
    }
}
