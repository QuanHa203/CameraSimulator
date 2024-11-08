using Google.Cloud.Firestore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CameraQQQ.Services
{
    public class FirestoreDbContext
    {
        //private string projectId = "camerasimulator-91360";
        private string projectId = "webrct-demo-f9ec7";
        private string collectionName = "Signaling";
        private static FirestoreDbContext instance = null!;

        private FirestoreDb firestoreDb;
        private FirestoreChangeListener firestoreChangeListener;
        private DocumentReference documentReference;
        private Answer answerFromCamera = null!;

        public static FirestoreDbContext Instance
        {
            get
            {
                if (instance == null)
                    instance = new FirestoreDbContext();
                return instance;
            }
        }

        private FirestoreDbContext()
        {
            //string pathToServiceAccountKey = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}camerasimulator-91360-firebase-adminsdk-ji7ap-de067214a8.json";

            string pathToServiceAccountKey = $"{Directory.GetCurrentDirectory()}{Path.DirectorySeparatorChar}P2PConnection{Path.DirectorySeparatorChar}webrct-demo-f9ec7-firebase-adminsdk-7apu4-0299f8b8c9.json";

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", pathToServiceAccountKey);

            firestoreDb = FirestoreDb.Create(projectId);
            documentReference = firestoreDb.Document($"{collectionName}/{LoginForm.userLogin.ConnectionCode}/{LoginForm.userLogin.UserName}/{LoginForm.userLogin.UserName}");

            // Register event value change.
            firestoreChangeListener = documentReference.Listen(snapshot =>
            {
                if (snapshot.Exists)
                {
                    foreach (var field in snapshot.ToDictionary())
                    {
                        if (field.Key == "Answer")
                        {
                            if (answerFromCamera == null && field.Value != null && field.Value.ToString()!.Length > 0)
                            {
                                dynamic answer = field.Value;
                                if (answer.Count > 0)
                                    answerFromCamera = new Answer
                                    {
                                        type = answer["type"],
                                        sdp = answer["sdp"]
                                    };
                            }
                            break;
                        }
                    }
                }
            });
        }

        public async Task UpdateOffer(string offer)
        {
            var offerJson = JsonConvert.DeserializeObject<Offer>(offer);
            Dictionary<string, object> updateOffer = new();
            updateOffer.Add("Offer", new
            {
                type = offerJson!.type,
                sdp = offerJson.sdp
            });

            try
            {
                await documentReference.UpdateAsync(updateOffer);
            }
            catch { }
        }

        public async Task UpdateCandidate(string candidate)
        {
            Dictionary<string, object> updateCandidate = new();
            var jsonCandidate = JsonConvert.DeserializeObject<Dictionary<string, object>>(candidate);
            try
            {
                await documentReference.UpdateAsync(new Dictionary<string, object>
                {
                    { "ICECandidateUser", FieldValue.ArrayUnion(jsonCandidate) }
                });
            }
            catch { }
        }

        public async Task Disconnect()
        {
            Dictionary<string, object> disconnectValue = new();
            disconnectValue.Add("Offer", new { });
            disconnectValue.Add("Answer", new { });
            disconnectValue.Add("ICECandidateCamera", new List<object>());
            disconnectValue.Add("ICECandidateUser", new List<object>());
            await documentReference.SetAsync(disconnectValue);
        }

        public async Task<Answer> GetAnswerFromCamera()
        {
            while (answerFromCamera == null) { }
            // Stop register value change            
            await firestoreChangeListener.StopAsync();
            return answerFromCamera;
        }

        public void ListenForIceCandidatesCamera(Action<string> getCandidate)
        {
            var docRef = firestoreDb.Document($"{collectionName}/{LoginForm.userLogin.ConnectionCode}/{LoginForm.userLogin.UserName}/{LoginForm.userLogin.UserName}");
            docRef.Listen(snapshot =>
            {
                foreach (var field in snapshot.ToDictionary())
                {
                    if (field.Key == "ICECandidateCamera")
                    {
                        if (field.Value is List<object> iceCandidates && iceCandidates.Count > 0)
                        {
                            foreach (var item in iceCandidates)
                            {
                                if (item is Dictionary<string, object> candidateData)
                                {
                                    string json = JsonConvert.SerializeObject(candidateData);
                                    getCandidate(json);
                                }
                            }
                        }
                    }
                }
            });
        }

        public class Offer
        {
            public string type = null!;
            public string sdp = null!;
        }

        public class Answer
        {
            public string type = null!;
            public string sdp = null!;
        }
    }
}