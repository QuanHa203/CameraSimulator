package com.example.cameraphone.handleP2P;

import android.app.Activity;
import android.content.Context;
import android.util.Log;
import android.webkit.JavascriptInterface;

import com.example.cameraphone.activity.MainActivity;

public class P2PInterface {
    private Activity activity = null;

    public P2PInterface(Activity c) {
        activity = c;
    }

    @JavascriptInterface
    public void receiveAnswer(String data, String userName) {
        FirestoreDbContext.getInstance().updateAnswer(data, userName);
    }

    @JavascriptInterface
    public void receiveIceCandidate(String data, String userName) {
        FirestoreDbContext.getInstance().updateCandidate(data, userName);
    }

    @JavascriptInterface
    public void disconnect(String userName) {
        FirestoreDbContext.getInstance().disconnect(userName);
    }
}
