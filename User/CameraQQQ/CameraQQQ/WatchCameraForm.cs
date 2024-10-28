using Microsoft.Web.WebView2.WinForms;
using System.Resources;

namespace CameraQQQ
{
    public partial class WatchCameraForm : Form
    {
        private WebView2 webView2;
        private bool isMicOn = false;
        private bool isVolumeOn = true;

        private readonly string _webPath = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}P2PConnection{Path.DirectorySeparatorChar}index.html";

        public WatchCameraForm()
        {
            InitializeComponent();
            webView2 = new WebView2()
            {
                Dock = DockStyle.Fill,
            };
            webView2.Source = new Uri(_webPath);
            this.Controls.Add(webView2);
        }

        private void WatchCameraForm_Load(object sender, EventArgs e)
        {
            
        }

        private void WatchCameraForm_SizeChanged(object sender, EventArgs e)
        {
            labelCameraName.Left = (labelCameraName.Parent!.Width - labelCameraName.Width) / 2;

            btnMic.Left = (btnMic.Parent!.Width - btnMic.Width -80) /2;
            btnVolume.Left = (btnVolume.Parent!.Width - btnVolume.Width + 80) / 2;
        }

        private void panelButton_SizeChanged(object sender, EventArgs e)
        {
        }

        private void btnMic_Click(object sender, EventArgs e)
        {
            if (isMicOn)
                btnMic.BackgroundImage = Properties.Resources.micOff;
            else
                btnMic.BackgroundImage = Properties.Resources.micOn;

            isMicOn = !isMicOn;
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            if (isVolumeOn)
                btnVolume.BackgroundImage = Properties.Resources.volumeOff;
            else
                btnVolume.BackgroundImage = Properties.Resources.volumeOn;

            isVolumeOn = !isVolumeOn;
        }
    }
}
