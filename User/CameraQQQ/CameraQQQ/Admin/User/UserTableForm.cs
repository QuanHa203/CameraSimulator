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
            dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUser.MultiSelect = false;
            dataGridViewUser.AllowUserToAddRows = false;
            dataGridViewUser.RowHeadersVisible = false;

            dataGridViewUser.Columns.Add("Id", "Id");
            dataGridViewUser.Columns.Add("IdRole", "Role");
            dataGridViewUser.Columns.Add("UserName", "User name");
            dataGridViewUser.Columns.Add("Password", "Password");
            dataGridViewUser.Columns.Add("Email", "Email");
            dataGridViewUser.Columns.Add("IsBan", "Ban");
            GetUsers();

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
                }
            }

            if (newUsers != null)
            {
                dataGridViewUser.Rows.Clear();
                for (int i = 0; i < newUsers.Count; i++)
                {
                    dataGridViewUser.Rows.Add([
                        newUsers[i].Id,
                        newUsers[i].IdRole == 1 ? "Admin" : "Client",
                        newUsers[i].UserName,
                        newUsers[i].Password,
                        newUsers[i].Email,
                        newUsers[i].IsBan == true ? "Yes" : "No"
                        ]);
                }
            }
        }

        private void labelCreateUser_Click(object sender, EventArgs e)
        {
            CreateUserForm f = new CreateUserForm(dataGridViewUser);
            DashboardForm.AddFormToPanel(f);
        }

        private void dataGridViewUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = (int)dataGridViewUser.Rows[e.RowIndex].Cells["Id"].Value;
                DashboardForm.AddFormToPanel(new UpdateUserForm(id));
            }
        }
    }
}
