using CameraQQQ.Client;

namespace CameraQQQ.P2PConnection;

[System.Runtime.InteropServices.ComVisible(true)]
public class CallCShapFromJavaScript
{
    private string _connectionCode = "";
    public CallCShapFromJavaScript(string connectionCode)
    {
        _connectionCode = connectionCode;
    }

    public static bool IsSetSuccessAnswer { get; set; } = false;
    public async Task SetOffer(string offer)
        => await FirestoreDbContext.Instance.UpdateOffer(offer, _connectionCode);

    public async Task SetIceCandidateUser(string iceCandidate)
        => await FirestoreDbContext.Instance.UpdateCandidateUser(iceCandidate, _connectionCode);

    public void ListeningIceCandidate()
    => IsSetSuccessAnswer = true;

    public void NotifyCameraConnected()
    {
        MessageBox.Show("Đã kết nối camera thành công!", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
    }

    public void NotifyCameraDisconnected()
    {
        MessageBox.Show("Camera đã mất kết nối!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}