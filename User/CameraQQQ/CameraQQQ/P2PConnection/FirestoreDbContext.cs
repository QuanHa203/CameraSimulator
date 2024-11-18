using CameraQQQ.Client;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace CameraQQQ.P2PConnection;

public class FirestoreDbContext
{
    //private string projectId = "camerasimulator-91360";
    private string projectId = "webrct-demo-f9ec7";
    private string collectionName = "Signaling";
    private static FirestoreDbContext instance = null!;

    private FirestoreDb firestoreDb = null!;    
    private FirestoreChangeListener listenerAnswer = null!;

    public static FirestoreDbContext Instance
    {
        get
        {
            if (instance == null)
            {
                lock (new object())
                {
                    instance = new FirestoreDbContext();
                }
            }
            return instance;
        }
    }

    private FirestoreDbContext()
    {
        //string pathToServiceAccountKey = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}camerasimulator-91360-firebase-adminsdk-ji7ap-de067214a8.json";        

        string pathToServiceAccountKey = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}P2PConnection{Path.DirectorySeparatorChar}webrct-demo-f9ec7-firebase-adminsdk-7apu4-0299f8b8c9.json";

        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", pathToServiceAccountKey);

        firestoreDb = FirestoreDb.Create(projectId);
        //documentReference = firestoreDb.Document($"{collectionName}/{LoginForm.User.ConnectionCode}");
        
    }

    public async Task UpdateOffer(string offer, string connectionCode)
    {
        DocumentReference documentReference = firestoreDb.Document($"{collectionName}/{connectionCode}");

        Offer offerJson = JsonConvert.DeserializeObject<Offer>(offer)!;
        Dictionary<string, object> updateOffer = new();
        updateOffer.Add($"{LoginForm.User.UserName}.Offer", new
        {
            sdp = offerJson.sdp,
            type = offerJson.type
        });

        await documentReference.UpdateAsync(updateOffer);
    }

    public async Task UpdateCandidateUser(string candidate, string connectionCode)
    {
        DocumentReference documentReference = firestoreDb.Document($"{collectionName}/{connectionCode}");

        Dictionary<string, object> updateCandidate = new();
        var jsonCandidate = JsonConvert.DeserializeObject<Dictionary<string, object>>(candidate);
        try
        {
            await documentReference.UpdateAsync(new Dictionary<string, object>
            {
                { $"{LoginForm.User.UserName}.ICECandidateUser", FieldValue.ArrayUnion(jsonCandidate) }
            });
        }
        catch { }
    }

    private async Task StopListernerAnswer()
    => await listenerAnswer.StopAsync();

    public void ListenForAnswerFromCameraChange(WatchCameraForm watchCameraForm)
    {
        //var docRef = firestoreDb.Document($"{collectionName}/{LoginForm.User.ConnectionCode}");
        var docRef = firestoreDb.Document($"{collectionName}/{watchCameraForm.ConnectionCode}");
        listenerAnswer = docRef.Listen(async (snapshot) =>
        {
            if (!snapshot.Exists)
                return;

            if (!snapshot.ToDictionary().TryGetValue(LoginForm.User.UserName, out object? obj))
                return;

            if (obj == null)
                return;

            if (obj is not Dictionary<string, object> value)
                return;

            if (!value.TryGetValue("Answer", out object? answer))
                return;

            if (!(answer is Dictionary<string, object>))
                return;

            if (answer is not Dictionary<string, object> answerValue)
                return;

            if (answerValue.Count == 0)
                return;

            string jsonAnswer = JsonConvert.SerializeObject(answer);            
            watchCameraForm.Invoke(() =>
            {
                watchCameraForm.webView2.CoreWebView2.ExecuteScriptAsync($"setAnswerFromCamera({jsonAnswer})");
            });

            await StopListernerAnswer();
        });
    }

    public void ListenForIceCandidatesCamera(WatchCameraForm watchCameraForm)
    {
        //var docRef = firestoreDb.Document($"{collectionName}/{LoginForm.User.ConnectionCode}");
        var docRef = firestoreDb.Document($"{collectionName}/{watchCameraForm.ConnectionCode}");
        docRef.Listen(snapshot =>
        {
            if (!snapshot.Exists)
                return;

            if (!snapshot.ToDictionary().ContainsKey(LoginForm.User.UserName))
                return;

            if (snapshot.ToDictionary()[LoginForm.User.UserName] is not Dictionary<string, object> userValue)
                return;

            if (!userValue.TryGetValue("ICECandidateCamera", out object iceCandidate))
                return;

            if (iceCandidate is not List<object> iceCandidateList)
                return;

            if (iceCandidateList.Count == 0)
                return;

            foreach (var item in iceCandidateList)
            {
                if (item is Dictionary<string, object> candidateData)
                {
                    string jsonIceCandidate = JsonConvert.SerializeObject(candidateData);
                    watchCameraForm.Invoke(() =>
                    {
                        watchCameraForm.webView2.CoreWebView2.ExecuteScriptAsync($"setIceCandidateFromCamera({jsonIceCandidate})");
                    });
                }
            }
        });
    }

    public async Task Disconnect(string connectionCode)
    {
        DocumentReference documentReference = firestoreDb.Document($"{collectionName}/{connectionCode}");

        Dictionary<string, object> disconnectValue = new();
        disconnectValue.Add($"{LoginForm.User.UserName}.Offer", new { });
        disconnectValue.Add($"{LoginForm.User.UserName}.Answer", new { });
        disconnectValue.Add($"{LoginForm.User.UserName}.ICECandidateCamera", new List<object>());
        disconnectValue.Add($"{LoginForm.User.UserName}.ICECandidateUser", new List<object>());
        await documentReference.UpdateAsync(disconnectValue);
    }

    public class Offer
    {
        public string type = null!;
        public string sdp = null!;
    }
}