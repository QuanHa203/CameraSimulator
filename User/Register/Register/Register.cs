using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Register
{
    public partial class Register : Form
    {
        private User user = null;
        public Register()
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
                var url = "https://localhost:7268/api/RegisterUserAPI/userRegister";

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
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
