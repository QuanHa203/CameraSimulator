using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraQQQ.User
{
    public partial class ForgotPasswordUser : Form
    {
        public static UserLogin userLogin;
        public ForgotPasswordUser()
        {
            InitializeComponent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string url = "";
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
                                MessageBox.Show("Yêu cầu đặt lại mật khẩu đã được gửi thành công. Vui lòng kiểm tra email.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy email hoặc có lỗi xảy ra.");
                            }
                        }
                    }
                }
            }
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Close();
        }
    }
}
