package com.example.cameraphone.handleP2P;

import com.example.cameraphone.activity.LoginActivity;
import com.google.firebase.firestore.DocumentReference;
import com.google.firebase.firestore.DocumentSnapshot;
import com.google.firebase.firestore.FieldValue;
import com.google.firebase.firestore.FirebaseFirestore;
import com.google.firebase.firestore.FirebaseFirestoreException;
import com.google.firebase.firestore.FirebaseFirestoreSettings;
import com.google.firebase.firestore.ListenerRegistration;
import com.google.firebase.firestore.MetadataChanges;
import com.google.firebase.firestore.Source;
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
    private ListenerRegistration listenerRegistrationOffer;
    private Object _offer = null;
    private FirestoreDbContext() {
        firestoreDb = FirebaseFirestore.getInstance();
        documentReference = firestoreDb.collection("Signaling").document(LoginActivity._camera.getConnectionCode()).collection("HaQuan").document("HaQuan");
        listenerRegistrationOffer = listenForOfferUser();
    }

    public static FirestoreDbContext getInstance() {
        if(instance == null)
            instance = new FirestoreDbContext();
        return instance;
    }

    public void updateAnswer(String answer) {
        Type mapType = new TypeToken<Map<String, Object>>() {}.getType();
        Map<String, Object> answerJson = new Gson().fromJson(answer, mapType);

        Map<String, Object> updateAnswer = new HashMap<>();
        updateAnswer.put("Answer", answerJson);
        documentReference.update(updateAnswer);
    }

    public void updateCandidate(String candidate) {
        Type mapType = new TypeToken<Map<String, Object>>() {}.getType();
        Map<String, Object> candidateValue = new Gson().fromJson(candidate, mapType);

        documentReference.update("ICECandidateCamera", FieldValue.arrayUnion(candidateValue));
    }

    public void listenForIceCandidateUser(Callback cb) {
        documentReference.addSnapshotListener((DocumentSnapshot data, FirebaseFirestoreException exception) -> {
            if (exception != null)
                return;

            if(data == null)
                return;

            if(!data.exists())
                return;

            Map<String, Object> json = data.getData();
            if(json.containsKey("ICECandidateUser")) {

                ArrayList<Object> iceCandidateArrayList = (ArrayList<Object>) json.get("ICECandidateUser");
                if(iceCandidateArrayList.size() == 0)
                    return;

                cb.setCandidate(iceCandidateArrayList);
            }
        });
    }

    public ListenerRegistration listenForOfferUser() {
        return documentReference.addSnapshotListener(MetadataChanges.INCLUDE, (DocumentSnapshot data, FirebaseFirestoreException exception) -> {
            if (exception != null)
                return;

            if(data == null)
                return;

            if(!data.exists())
                return;

            if(data.getMetadata().isFromCache())
                return;

            Map<String, Object> json = data.getData();
            if(json.containsKey("Offer")) {
                Map<String, Object> offerValue = (HashMap<String, Object>)json.get("Offer");
                if(offerValue.size() == 0)
                    _offer = null;
                else
                    _offer = offerValue;
            }
        });
    }

    public String getOfferFromUser() {
        while (_offer == null) { }
        return new Gson().toJson(_offer);
    }

    public void setNullOffer() {
        _offer = null;
    }

    public void disconnect() {
        Map<String, Object> disconnectValue = new HashMap<>();
        disconnectValue.put("Offer", new HashMap<String, Object>());
        disconnectValue.put("Answer", new HashMap<String, Object>());
        disconnectValue.put("ICECandidateCamera", new ArrayList());
        disconnectValue.put("ICECandidateUser", new ArrayList());
        documentReference.set(disconnectValue);
    }
}
