namespace CameraQQQ.P2PConnection;

[System.Runtime.InteropServices.ComVisible(true)]
public class CallCShapFromJavaScript
{
    public async Task SetOffer(string offer)
        =>await FirestoreDbContext.Instance.UpdateOffer(offer);

    public async Task SetIceCandidateUser(string iceCandidate)
        => await FirestoreDbContext.Instance.UpdateCandidateUser(iceCandidate);

    public void NotifyCameraConnected()
    {
        MessageBox.Show("Đã kết nối camera thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
    }

    public void NotifyCameraDisconnected()
    {
        MessageBox.Show("Camera đã mất kết nối!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
    }
}