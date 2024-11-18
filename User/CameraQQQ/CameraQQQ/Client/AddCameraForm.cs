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

namespace CameraQQQ.Client
{
    public partial class AddCameraForm : Form
    {
        public AddCameraForm()
        {
            InitializeComponent();
        }

        private void AddCameraForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionCode = textBoxConnectionCode.Text;
            if (connectionCode.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã kết nối");
                return;
            }

            string path = $"ConnectionCamera?connectionCode={connectionCode}&userName={LoginForm.User.UserName}";
            var response = SendRequestToServer.SendRequest(HttpMethod.Post, path);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Đã thêm camera thành công!");
                Camera camera = JsonConvert.DeserializeObject<Camera>(response.Data)!;
                LoginForm.User.Cameras!.Add(camera);
                HomeForm.AddFormToPanel(new CameraListForm());
            }
            else
            {
                MessageBox.Show(response.Data);
            }
        }
    }
}
