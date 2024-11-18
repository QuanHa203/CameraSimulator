using CameraQQQ.Admin.Camera;
using CameraQQQ.Models;
using CameraQQQ.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CameraQQQ.Admin.User
{
    public partial class CreateUserForm : Form
    {
        DataGridView dataGridView;
        public static CameraQQQ.Models.User User { get; set; }
        public CreateUserForm(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string username = txtCreateUser.Text;
            string password = txtCreatePass.Text;
            string email = txtCreateEmail.Text;
            string url = $"CRUDUser/CreateUser?username={username}&password={password}&email={email}";

            var response = SendRequestToServer.SendRequest(HttpMethod.Post, url);
            string data = response.Data;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var newUser = JsonConvert.DeserializeObject<CameraQQQ.Models.User>(data);

                if (newUser != null)
                {
                    UserTableForm.newUsers.Add(newUser);
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = UserTableForm.newUsers;
                    MessageBox.Show("Thêm thành công", "Thành công");
                    DashboardForm.AddFormToPanel(new UserTableForm());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Không thể thêm người dùng. Dữ liệu không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show($"Thêm thất bại: {response.Data}");
            }
        }
    }
}
