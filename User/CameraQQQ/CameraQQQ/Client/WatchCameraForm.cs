using CameraQQQ.P2PConnection;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;

namespace CameraQQQ.Client
{
    public partial class WatchCameraForm : Form
    {
        private readonly string _webPath = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}P2PConnection{Path.DirectorySeparatorChar}index.html";

        private bool isMicOn = false;
        private bool isVolumeOn = true;
        private bool IsMicOn
        {
            get
            {
                return isMicOn;
            }
            set
            {
                if (isMicOn)
                {
                    btnMic.BackgroundImage!.Dispose();
                    btnMic.BackgroundImage = Properties.Resources.micOff;
                    webView2.CoreWebView2.ExecuteScriptAsync("turnOffMicro();");
                }
                else
                {
                    btnMic.BackgroundImage!.Dispose();
                    btnMic.BackgroundImage = Properties.Resources.micOn;
                    webView2.CoreWebView2.ExecuteScriptAsync("turnOnMicro();");
                }

                isMicOn = value;
            }
        }
        private bool IsVolumeOn
        {
            get
            {
                return isVolumeOn;
            }
            set
            {
                if (isVolumeOn)
                {
                    btnVolume.BackgroundImage!.Dispose();
                    btnVolume.BackgroundImage = Properties.Resources.volumeOff;
                    webView2.CoreWebView2.ExecuteScriptAsync("turnOffVolume();");
                }
                else
                {
                    btnVolume.BackgroundImage!.Dispose();
                    btnVolume.BackgroundImage = Properties.Resources.volumeOn;
                    webView2.CoreWebView2.ExecuteScriptAsync("turnOnVolume();");
                }
                isVolumeOn = value;
            }
        }        
        private EventHandler<CoreWebView2WebMessageReceivedEventArgs> messageReceivedHandlerPermissionState = null!;
        public WebView2 webView2 = null!;

        public WatchCameraForm()
        {
            InitializeComponent();
            LoginForm.User = new Models.User
            {
                UserName = "HaQuan",
                ConnectionCode = "111111111"
            };
            InitWebView();
        }

        private async void WatchCameraForm_Load(object sender, EventArgs e)
        {
            await webView2.EnsureCoreWebView2Async();

            // Create Object callCSharp in JS
            webView2.CoreWebView2.AddHostObjectToScript("callCSharp", new CallCShapFromJavaScript());


            // Register event
            webView2.CoreWebView2.WebMessageReceived += messageReceivedHandlerPermissionState;
        }

        public void InitWebView()
        {
            webView2 = new WebView2()
            {
                Dock = DockStyle.Fill,
            };

            webView2.Source = new Uri(_webPath);
            panelWeb.Controls.Add(webView2);
            messageReceivedHandlerPermissionState += HandlePermissionState!;
            
        }

        private void HandlePermissionState(object s, CoreWebView2WebMessageReceivedEventArgs e)
        {
            string message = e.TryGetWebMessageAsString();

            // Handle message from JavaScript
            if (message == "Granted")
            {
                webView2.CoreWebView2.WebMessageReceived -= messageReceivedHandlerPermissionState;
                Task t = ExecutePeerToPeerConnectionAsync();
            }
            else if (message == "Denied")
            {
                MessageBox.Show("Vui lòng cấp quyền truy cập Microphone và Camera hoặc tắt các ứng dụng đang bật camera!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                webView2.CoreWebView2.WebMessageReceived -= messageReceivedHandlerPermissionState;
                this.Close();
            }
        }

        private async Task ExecutePeerToPeerConnectionAsync()
        {
            // Call webView2.CoreWebView2.ExecuteScriptAsync() by main thread. Because WebView2 is must execute in UI thread,
            await this.Invoke(async () =>
            {
                // Create Answer
                await webView2.CoreWebView2.ExecuteScriptAsync("createOffer();");
            });            

            // Init new thread to listen answer and then set answer to RTCPeerConnection.            
            FirestoreDbContext.Instance.ListenForAnswerFromCameraChange(this);

            // Listening IceCandidate in Firebase to set ICE Candidate to RTCPeerConnection
            Task t = Task.Run(() =>
            {
                while (CallCShapFromJavaScript.IsSetSuccessAnswer == false) { }
                FirestoreDbContext.Instance.ListenForIceCandidatesCamera(this);
            });
        }

        private async void WatchCameraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await FirestoreDbContext.Instance.Disconnect();            
            //webView2.Dispose();
        }

        private void btnMic_Click(object sender, EventArgs e)
            => IsMicOn = !IsMicOn;

        private void btnVolume_Click(object sender, EventArgs e)
            => IsVolumeOn = !IsVolumeOn;

        private void WatchCameraForm_SizeChanged(object sender, EventArgs e)
        {
            labelCameraName.Left = (labelCameraName.Parent!.Width - labelCameraName.Width) / 2;

            btnMic.Left = (btnMic.Parent!.Width - btnMic.Width - 80) / 2;
            btnVolume.Left = (btnVolume.Parent!.Width - btnVolume.Width + 80) / 2;

            btnMic.Top = btnMic.Parent!.Height - btnMic.Height - 20;
            btnVolume.Top = btnVolume.Parent!.Height - btnVolume.Height - 20;
        }
    }
}
