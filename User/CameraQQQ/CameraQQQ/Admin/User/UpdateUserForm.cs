using CameraQQQ.Services;

namespace CameraQQQ.Admin.User
{

    public partial class UpdateUserForm : Form
    {
        private int idUser;
        public UpdateUserForm(int id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            comboBoxIsBan.Items.Add("No");
            comboBoxIsBan.Items.Add("Yes");

            CameraQQQ.Models.User user = UserTableForm.newUsers.FirstOrDefault(u => u.Id == idUser)!;
            txtUpdateEmail.Text = user.Email;
            txtUpdatePass.Text = user.Password;
            txtUpdateUser.Text = user.UserName;
            comboBoxIsBan.SelectedIndex = user.IsBan == true ? 1 : 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string username = txtUpdateUser.Text;
            string password = txtUpdatePass.Text;
            string email = txtUpdateEmail.Text;
            bool isBan = comboBoxIsBan.SelectedIndex == 0 ? false : true;

            string url = $"CRUDUser/UpdateUser?id={idUser}&name={username}&password={password}&email={email}&isBan={isBan}";

            var response = SendRequestToServer.SendRequest(HttpMethod.Patch, url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Cập nhật thành công");
                var user = UserTableForm.newUsers.FirstOrDefault(u => u.Id == idUser);
                if (user != null)
                {
                    user.UserName = username;
                    user.Password = password;
                    user.Email = email;
                    user.IsBan = isBan;
                }

                this.Close();
                DashboardForm.AddFormToPanel(new UserTableForm());
            }
            else
            {
                MessageBox.Show($"Cập nhật thất bại: {response.Data}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string url = $"CRUDUser/DeleteUser?id={idUser}";
            var response = SendRequestToServer.SendRequest(HttpMethod.Delete, url);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(response.Data);

                
                foreach (var user in UserTableForm.newUsers)
                {
                    if (user.Id == idUser)
                    {
                        UserTableForm.newUsers.Remove(user);
                        break;
                    }
                }
                this.Close();
                DashboardForm.AddFormToPanel(new UserTableForm());
            }
            else
            {
                MessageBox.Show(response.Data);
            }
        }
    }
}
