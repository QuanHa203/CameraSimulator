package com.example.cameraphone;

import java.util.concurrent.atomic.AtomicReference;

import okhttp3.MediaType;
import okhttp3.OkHttpClient;
import okhttp3.Request;
import okhttp3.RequestBody;
import okhttp3.Response;

public class CallApi  {
    private static String serverBase = "http://192.168.6.225:5000";

    public static Response onPostLoginAsync(String cameraName, String password) {
        String url = serverBase + "/api/LoginCamera/login?cameraName=" + cameraName + "&password=" + password;
        OkHttpClient okHttpClient = new OkHttpClient();
        Request request = new Request.Builder()
                                     .url(url)
                                     .post(RequestBody.create("", MediaType.get("application/json")))
                                     .build();

        AtomicReference<Response> result = new AtomicReference<>();
        Thread thread = new Thread(() -> {
            try {
                Response response = okHttpClient.newCall(request).execute();
                result.set(response);
            }
            catch (Exception ex) {
                result.set(null);
            }
        });

        thread.start();
        try {
            thread.join();
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        return result.get();
    }

    public static Response onPostRegisterAsync(String cameraName, String password) {
        OkHttpClient okHttpClient = new OkHttpClient();

        String url = serverBase + "/RegisterCamera/RegisterCamera?cameraName=" + cameraName +"&password=" + password;
        Request request = new Request.Builder()
                                     .url(url)
                                     .post(RequestBody.create("", MediaType.get("application/json")))
                                     .build();

        AtomicReference<Response> result = new AtomicReference<>();
        Thread thread = new Thread(() -> {
            try {
                Response response = okHttpClient.newCall(request).execute();
                result.set(response);
            }
            catch (Exception ex) {
                result.set(null);
            }
        });
        thread.start();
        try {
            thread.join();
        } catch (InterruptedException e) {
            throw new RuntimeException(e);
        }
        return result.get();
    }
}
