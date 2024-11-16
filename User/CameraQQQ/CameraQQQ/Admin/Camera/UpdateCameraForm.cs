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

namespace CameraQQQ.Admin.Camera
{
    public partial class UpdateCameraForm : Form
    {

        public UpdateCameraForm(string value1, string value2, string value3, string value4)
        {
            InitializeComponent();
            textBoxId.Text = value1;
            textBoxCameraName.Text = value2;
            textBoxPassword.Text = value3;
            textBoxConnectionCode.Text = value4;
           textBoxId.Enabled = false;
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var url = "/Camera"; 
            var camera = new CameraQQQ.Models.Camera()
            {
                Id = int.Parse(textBoxId.Text), 
                CameraName = textBoxCameraName.Text, 
                Password = textBoxPassword.Text,     
                ConnectionCode = textBoxConnectionCode.Text 
            };

            var json = JsonConvert.SerializeObject(camera); 
            var response = SendRequestToServer.SendRequest(HttpMethod.Put, url, json); 

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Cập nhật thành công");
                var editCamera = JsonConvert.DeserializeObject<CameraQQQ.Models.Camera>(response.Data);
                CameraTableForm.listCameras.FirstOrDefault(c => c.Id == editCamera.Id);
                CameraQQQ.Models.Camera edit = CameraTableForm.listCameras.FirstOrDefault(c => c.Id == editCamera.Id);
                    if (edit != null)
                    {
                    edit.CameraName = editCamera.CameraName;
                    edit.Password=editCamera.Password;
                    edit.ConnectionCode = editCamera.ConnectionCode;
                    } 
                    
                this.Close(); 
            }
            else
            {
                MessageBox.Show(response.Data); 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cameraId = int.Parse(textBoxId.Text); 
            var url = $"/Camera?Id={cameraId}"; 

            var response = SendRequestToServer.SendRequest(HttpMethod.Delete, url);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                
                MessageBox.Show("Xóa thành công");           
                CameraQQQ.Models.Camera removeCamera = CameraTableForm.listCameras.FirstOrDefault(c => c.Id == cameraId);
                if (removeCamera != null) CameraTableForm.listCameras.Remove(removeCamera);
                this.Close(); 

            }
            else
            {
                MessageBox.Show(response.Data); 
            }

        }
    }
}
