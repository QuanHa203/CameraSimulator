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
        public async Task SetOffer(string offer)
            =>await FirestoreDbContext.Instance.UpdateOffer(offer);

        public async Task SetIceCandidateUser(string iceCandidate)
            => await FirestoreDbContext.Instance.UpdateCandidate(iceCandidate);

        public void CameraDisconnect()
            => MessageBox.Show("Camera đã mất kết nối!", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
    }
}
