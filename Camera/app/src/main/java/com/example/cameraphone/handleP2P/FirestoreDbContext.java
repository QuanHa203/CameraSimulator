package com.example.cameraphone.handleP2P;

import android.app.Activity;

import com.example.cameraphone.activity.LoginActivity;
import com.example.cameraphone.activity.MainActivity;
import com.google.firebase.firestore.CollectionReference;
import com.google.firebase.firestore.DocumentReference;
import com.google.firebase.firestore.DocumentSnapshot;
import com.google.firebase.firestore.FieldValue;
import com.google.firebase.firestore.FirebaseFirestore;
import com.google.firebase.firestore.FirebaseFirestoreException;
import com.google.firebase.firestore.MetadataChanges;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map;

public class FirestoreDbContext {
    private static  FirestoreDbContext instance;
    private FirebaseFirestore firestoreDb;
    private DocumentReference documentReference;

    private ArrayList<String> offerWasSet = new ArrayList<String>();
    private HashMap<String, Integer> iceCandidateWasSet = new HashMap<String, Integer>();

    private FirestoreDbContext() {
        firestoreDb = FirebaseFirestore.getInstance();
    }

    public void createDocumentConnectionCode(String connectionCode) {
        firestoreDb.collection("Signaling/").document(connectionCode).set(new HashMap<String, Object>());
    }

    public void setDocumentConnectionCode() {
        documentReference = firestoreDb.document("Signaling/" + LoginActivity._camera.getConnectionCode());
    }

    public static FirestoreDbContext getInstance() {
        if(instance == null)
            instance = new FirestoreDbContext();
        return instance;
    }

    public void updateAnswer(String answer, String userName) {
        Type mapType = new TypeToken<Map<String, Object>>() {}.getType();
        Map<String, Object> answerJson = new Gson().fromJson(answer, mapType);

        documentReference.update(userName + ".Answer", answerJson);
    }

    public void updateCandidate(String candidate, String userName) {
        Type mapType = new TypeToken<Map<String, Object>>() {}.getType();
        Map<String, Object> candidateValue = new Gson().fromJson(candidate, mapType);

        documentReference.update(userName + ".ICECandidateCamera", FieldValue.arrayUnion(candidateValue));
    }

    public void listenForOfferUsers(Activity activity) {
        documentReference.addSnapshotListener(activity, MetadataChanges.INCLUDE, (DocumentSnapshot data, FirebaseFirestoreException exception) -> {
            if (exception != null)
                return;

            if(data == null)
                return;

            if(!data.exists())
                return;

            if(data.getMetadata().isFromCache())
                return;

            Object[] userNames = data.getData().keySet().toArray();
            Object[] fields =  data.getData().values().toArray();

            for(int i = 0; i < fields.length; i++) {
                if(offerWasSet.contains(userNames[i]))
                    continue;

                HashMap<String, Object> userValue = (HashMap<String, Object>) fields[i];
                if(!userValue.containsKey("Offer") )
                    continue;

                Map<String, Object> offerValue = (HashMap<String, Object>) userValue.get("Offer");
                if(offerValue.size() == 0)
                    continue;

                String userName = userNames[i].toString();
                String offerJson = new Gson().toJson(offerValue);

                activity.runOnUiThread(() -> {
                    // Set offer from user
                    MainActivity.webView.evaluateJavascript("javascript:handlerOfferFromSenders(" + offerJson +", '" + userName + "');", null);
                });

                offerWasSet.add(userName);
            }
        });
    }

    public void listenForIceCandidateUser(Activity activity) {
        documentReference.addSnapshotListener(activity, MetadataChanges.INCLUDE, (DocumentSnapshot data, FirebaseFirestoreException exception) -> {
            if (exception != null)
                return;

            if(data == null)
                return;

            if(!data.exists())
                return;

            if(data.getMetadata().isFromCache())
                return;

            Object[] userNames = data.getData().keySet().toArray();
            Object[] fields =  data.getData().values().toArray();

            for(int i = 0; i < fields.length; i++) {
                HashMap<String, Object> userValue = (HashMap<String, Object>) fields[i];
                if(!userValue.containsKey("ICECandidateUser") )
                    continue;

                ArrayList<Object> iceCandidateArrayList = (ArrayList<Object>) userValue.get("ICECandidateUser");
                int iceCandidateArrayListSize = iceCandidateArrayList.size();

                if(iceCandidateArrayList.size() == 0)
                    continue;

                String userName = userNames[i].toString();

                if(iceCandidateWasSet.containsKey(userNames[i].toString()) && iceCandidateWasSet.get(userNames[i].toString()) == iceCandidateArrayList.size()) {
                    activity.runOnUiThread(() -> {
                        // Set ICE candidate from user
                        MainActivity.webView.evaluateJavascript("javascript:setIceCandidateFromSender('" + userName + "');", null);
                    });
                    continue;
                }

                String iceCandidateJson = new Gson().toJson(iceCandidateArrayList);

                activity.runOnUiThread(() -> {
                    // Push IceCandidate in Queue
                    MainActivity.webView.evaluateJavascript("javascript:pushIceCandidateInPending(" + iceCandidateJson +", '" + userName + "');", null);
                });

                iceCandidateWasSet.put(userNames[i].toString(), iceCandidateArrayList.size());
            }
        });
    }

    public void disconnect(String userName) {
        Map<String, Object> disconnectValue = new HashMap<>();
        disconnectValue.put(userName + ".Offer", new HashMap<String, Object>());
        disconnectValue.put(userName + ".Answer", new HashMap<String, Object>());
        disconnectValue.put(userName + ".ICECandidateCamera", new ArrayList());
        disconnectValue.put(userName + ".ICECandidateUser", new ArrayList());
        documentReference.update(disconnectValue);

        offerWasSet.remove(userName);
        iceCandidateWasSet.remove(userName);
    }
}
