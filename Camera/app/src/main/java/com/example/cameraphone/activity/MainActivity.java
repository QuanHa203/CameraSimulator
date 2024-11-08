package com.example.cameraphone.activity;

import android.os.Bundle;
import androidx.appcompat.app.AppCompatActivity;

import android.util.Log;
import android.webkit.PermissionRequest;
import android.webkit.WebChromeClient;
import android.webkit.WebView;
import android.webkit.WebViewClient;
import android.widget.Toast;

import com.example.cameraphone.R;
import com.example.cameraphone.handleP2P.FirestoreDbContext;
import com.example.cameraphone.handleP2P.P2PInterface;
import com.google.gson.Gson;

public class MainActivity extends AppCompatActivity {
    private WebView webView;
    private boolean isPageLoaded = false;
    private P2PInterface p2PInterface;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        webView = findViewById(R.id.webView);

        LoginActivity._camera.setConnectionCode("111111111");
        LoginActivity._camera.setCameraName("CameraTest");

        p2PInterface = new P2PInterface(this);

        initWebView();
        handlerP2PConnection();
    }

    private void initWebView() {
        isPageLoaded = false;
        webView.getSettings().setJavaScriptEnabled(true);
        webView.getSettings().setMediaPlaybackRequiresUserGesture(false);
        webView.addJavascriptInterface(p2PInterface, "Android");
        WebView.setWebContentsDebuggingEnabled(true);
        webView.setWebChromeClient(new WebChromeClient() {
            @Override
            public void onPermissionRequest(PermissionRequest request) {
                request.grant(request.getResources());
            }
        });

        webView.setWebViewClient(new WebViewClient() {
            @Override
            public void onPageFinished(WebView view, String url) {
                isPageLoaded = true; // Đặt cờ thành true khi trang đã tải xong
            }
        });

        webView.loadUrl("file:///android_asset/index.html");
    }

    public void handlerP2PConnection() {
        new Thread(() -> {
            while (!isPageLoaded) {}

            // Get Offer from User
            String offerJson = FirestoreDbContext.getInstance().getOfferFromUser();

            runOnUiThread(() -> {
                // set Offer From Sender to Camera
                webView.evaluateJavascript("javascript:setOfferFromSender(" + offerJson + ");", null);
            });

            // Get Amswer from JavaScript to save in Firebase
            String answer = p2PInterface.getAnswer();

            // Save Amswer in Firebase
            FirestoreDbContext.getInstance().updateAnswer(answer);

            // Set ICE Candidate from User
            FirestoreDbContext.getInstance().listenForIceCandidateUser(candidate -> {
                String candidateJson = new Gson().toJson(candidate);
                runOnUiThread(() -> webView.evaluateJavascript("javascript:setIceCandidateFromSender(" + candidateJson + ");", null));
            });
        }).start();
    }
}