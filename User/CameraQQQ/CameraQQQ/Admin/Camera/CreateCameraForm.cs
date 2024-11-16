using CameraQQQ.Services;
using Newtonsoft.Json;
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

namespace CameraQQQ.Admin.Camera
{
    public partial class CreateCameraForm : Form
    {
        
        public CreateCameraForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var url = "/Camera";
            var camera = new CameraQQQ.Models.Camera()
            {
                CameraName=textBoxCameraName.Text,
                Password=textBoxPassword.Text,
                ConnectionCode=textBoxConnectionCode.Text,
            };

            var json = JsonConvert.SerializeObject(camera);
            var response = SendRequestToServer.SendRequest(HttpMethod.Post, url, json);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Thêm thành công");
                var newCamera = JsonConvert.DeserializeObject<CameraQQQ.Models.Camera>(response.Data);
                CameraTableForm.listCameras.Add(newCamera);
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Data);
            }

        }
    }
}
