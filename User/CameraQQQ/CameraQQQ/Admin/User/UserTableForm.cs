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
using CameraQQQ.Admin.Camera;
using CameraQQQ.Models;
using CameraQQQ.Services;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace CameraQQQ.Admin.User
{
    public partial class UserTableForm : Form
    {
        public static List<CameraQQQ.Models.User> newUsers = null;
        public UserTableForm()
        {
            InitializeComponent();
        }

        private void UserTableForm_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateUserForm f = new CreateUserForm(dataGridView1);
            f.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này?", "Xóa người dùng", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    DeleteUser(userId);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một người dùng để xóa.");
            }
        }

        public void GetUsers()
        {
            if (newUsers == null)
            {
                var url = "/CRUDUser/UserList";
                var response = SendRequestToServer.SendRequest(HttpMethod.Get, url);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    newUsers = JsonConvert.DeserializeObject<List<CameraQQQ.Models.User>>(response.Data);
                    if (newUsers != null)
                    {
                        dataGridView1.DataSource = newUsers;
                    }
                    else
                    {
                        MessageBox.Show("Hiển thị thất bại");
                    }
                }
            }
            else
            {
                dataGridView1.DataSource = newUsers;
            }
        }

        public void DeleteUser(int id)
        {
            string url = $"CRUDUser/DeleteUser?id={id}";
            var response = SendRequestToServer.SendRequest(HttpMethod.Delete, url);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Xóa thành công!");
                var data = JsonConvert.DeserializeObject<List<CameraQQQ.Models.User>>(response.Data);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("Xóa không thành công!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateUserForm updateUserForm = new UpdateUserForm(dataGridView1);
            updateUserForm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
