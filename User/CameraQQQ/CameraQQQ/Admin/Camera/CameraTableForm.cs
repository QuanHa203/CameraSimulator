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
using CameraQQQ.Models;

namespace CameraQQQ.Admin.Camera
{
    public partial class CameraTableForm : Form
    {
        public static CameraQQQ.Models.Camera Camera { get; set; }
        public CameraTableForm()
        {
            InitializeComponent();
            Load();
            dataGridViewCamera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static List<CameraQQQ.Models.Camera> listCameras = null;
       
        public void Load()
        {
            if (listCameras == null)
            {
                string url = "/Camera";
                var response = SendRequestToServer.SendRequest(HttpMethod.Get, url);

                if (response.StatusCode == HttpStatusCode.OK)
                {

                    listCameras = JsonConvert.DeserializeObject<List<CameraQQQ.Models.Camera>>(response.Data);

                    
                }
            }
            if (listCameras != null)
            {

                dataGridViewCamera.DataSource = listCameras;

                MessageBox.Show("Dữ liệu đã được tải thành công!");
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị.");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DashboardForm.AddFormToPanel(new CreateCameraForm());
            
        }

        private void dataGridViewCamera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                
                string value1 = dataGridViewCamera.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                string value2 = dataGridViewCamera.Rows[e.RowIndex].Cells["CameraName"].Value.ToString();
                string value3 = dataGridViewCamera.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                string value4 = dataGridViewCamera.Rows[e.RowIndex].Cells["ConnectionCode"].Value.ToString();
                DashboardForm.AddFormToPanel(new UpdateCameraForm(value1, value2, value3, value4));
                
                
            }
        }
    }
}
