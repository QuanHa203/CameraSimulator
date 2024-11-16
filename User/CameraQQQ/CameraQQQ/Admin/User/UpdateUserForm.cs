using CameraQQQ.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CameraQQQ.Admin.User
{
    
    public partial class UpdateUserForm : Form
    {
        DataGridView dataGridView;
        public UpdateUserForm(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count >= 0)
            {
                int userID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
                string username = txtUpdateUser.Text;
                string password = txtUpdatePass.Text;
                string email = txtUpdateEmail.Text;
                bool isBan = btnIsBan.Checked;

                string url = $"CRUDUser/UpdateUser?id={userID}&name={username}&password={password}&email={email}&isBan={isBan}";

                var response = SendRequestToServer.SendRequest(HttpMethod.Patch, url);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Cập nhật thành công");
                    RefreshUserList();
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Cập nhật thất bại: {response.Data}");
                }
            }
            else {
                MessageBox.Show("Vui lòng chọn một người dùng để cập nhật.");
            }
        }
        private void RefreshUserList()
        {
            var url = "/CRUDUser/UserList";
            var response = SendRequestToServer.SendRequest(HttpMethod.Get, url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<List<CameraQQQ.Models.User>>(response.Data);
                if (data != null)
                {
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = data;
                }
            }
        }
    }
}
