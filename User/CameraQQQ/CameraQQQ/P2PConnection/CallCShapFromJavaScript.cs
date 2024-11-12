using CameraQQQ.Client;
using CameraQQQ.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraQQQ.P2PConnection
{    
    [System.Runtime.InteropServices.ComVisible(true)]
    public class CallCShapFromJavaScript
    {
        public static bool? IsDisconnected {  get; private set; } = null;

        public async Task SetOffer(string offer)
            =>await FirestoreDbContext.Instance.UpdateOffer(offer);

        public async Task SetIceCandidateUser(string iceCandidate)
            => await FirestoreDbContext.Instance.UpdateCandidateUser(iceCandidate);

        public void NotifyCameraConnected()
        {
            MessageBox.Show("Đã kết nối camera thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            IsDisconnected = true;
        }

        public async void NotifyCameraDisconnected()
        {
            MessageBox.Show("Camera đã mất kết nối!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            await FirestoreDbContext.Instance.Disconnect();
            IsDisconnected = false;
        }
    }
}
