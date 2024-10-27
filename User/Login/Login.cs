using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace Login
{
    public class User
    {
        public string IdRole { get; set; }
        public string UserName { get; set; }
    }
    public partial class Login : Form
    {
        private User user = null;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string url = $"https://localhost:7268/Login?username={userName}&password={password}";


            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                using (HttpRequestMessage httpRequestMessage = new HttpRequestMessage())
                {
                    httpRequestMessage.Method = HttpMethod.Post;
                    using(HttpResponseMessage httpResponseMessage = client.Send(httpRequestMessage))
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
                            user = JsonConvert.DeserializeObject<User>(data);
                                MessageBox.Show("Đăng nhập thành công");
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
    }
}
