package com.example.cameraphone.handleP2P;

import android.app.Activity;
import android.content.Context;
import android.util.Log;
import android.webkit.JavascriptInterface;

import com.example.cameraphone.activity.MainActivity;

public class P2PInterface {
    private Activity activity = null;
    private String answer = null;

    public P2PInterface(Activity c) {
        activity = c;
    }

    public String getAnswer() {
        while (answer == null) {}
        return answer;
    }

    @JavascriptInterface
    public void receiveAnswer(String data) {
        answer = data;
    }

    @JavascriptInterface
    public void receiveIceCandidate(String data) {
        FirestoreDbContext.getInstance().updateCandidate(data);
    }

    @JavascriptInterface
    public void disconnect() {
        FirestoreDbContext.getInstance().disconnect();
    }

    @JavascriptInterface
    public void refreshActivity() {
        FirestoreDbContext.getInstance().setNullOffer();
        activity.runOnUiThread(() -> activity.recreate());
    }
}
