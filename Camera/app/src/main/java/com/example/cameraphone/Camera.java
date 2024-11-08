package com.example.cameraphone;

import com.google.gson.annotations.SerializedName;

public class Camera {
    @SerializedName("cameraName")
    private String cameraName;

    @SerializedName("connectionCode")
    private String connectionCode;

    public String getCameraName() {
        return cameraName;
    }

    public void setCameraName(String cameraName) {
        this.cameraName = cameraName;
    }

    public String getConnectionCode() {
        return connectionCode;
    }

    public void setConnectionCode(String connectionCode) {
        this.connectionCode = connectionCode;
    }
}
