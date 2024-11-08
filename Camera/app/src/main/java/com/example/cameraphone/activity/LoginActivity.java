package com.example.cameraphone.activity;

import android.Manifest;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;

import com.example.cameraphone.CallApi;
import com.example.cameraphone.Camera;
import com.example.cameraphone.R;
import com.google.gson.Gson;
import okhttp3.Response;

public class LoginActivity extends AppCompatActivity {
    private static final int REQUEST_CAMERA_MIC_PERMISSION = 1;
    private EditText editTextLoginCameraName;
    private EditText editTextLoginPassword;
    private TextView textViewRedirectToRegisterActivity;
    private Button btnLogin;
    public static Camera _camera = new Camera();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_login);

        // Kiểm tra và yêu cầu quyền camera và micro nếu cần thiết
        if (!hasPermissions()) {
            requestPermissions();
        }

        if (!hasPermissions()) {
            Toast.makeText(this, "Vui lòng cấp đủ quyền truy cập camera và micro", Toast.LENGTH_SHORT).show();
            try {
                Thread.sleep(2000);
                finish();
            }
            catch (Exception ex) {}
        }

        editTextLoginCameraName = findViewById(R.id.editTextLoginCameraName);
        editTextLoginPassword = findViewById(R.id.editTextLoginPassword);
        textViewRedirectToRegisterActivity = findViewById(R.id.textViewRedirectToRegisterActivity);
        btnLogin = findViewById(R.id.btnLogin);

        btnLogin.setOnClickListener(view -> {
            String cameraName = editTextLoginCameraName.getText().toString();
            String password = editTextLoginPassword.getText().toString();

            if(cameraName.trim().length() == 0) {
                Toast.makeText(this, "Camera name không được bỏ trống", Toast.LENGTH_SHORT).show();
                return;
            }

            if(password.trim().length() == 0) {
                Toast.makeText(this, "Password không được bỏ trống", Toast.LENGTH_SHORT).show();
                return;
            }

            Response response = CallApi.onPostLoginAsync(cameraName, password);
            if(response == null) {
                Toast.makeText(this, "Error: Không thể kết nối dến server", Toast.LENGTH_SHORT).show();
                return;
            }

            int statusCode = response.code();
            try {
                String responseData = response.body().string();
                if(statusCode != 200) {
                    Toast.makeText(this, responseData, Toast.LENGTH_SHORT).show();
                    return;
                }

                _camera = new Gson().fromJson(responseData, Camera.class);
                _camera.setConnectionCode(_camera.getConnectionCode().trim());

                Toast.makeText(this, "Đăng nhập thành công!", Toast.LENGTH_SHORT).show();
                Intent intent = new Intent(this, MainActivity.class);
                Thread.sleep(2000);
                this.finish();
                startActivity(intent);
            }
            catch (Exception ex) {
                Toast.makeText(this, "Error: " + ex.getMessage(), Toast.LENGTH_SHORT).show();
            }
        });

        textViewRedirectToRegisterActivity.setOnClickListener(view -> {
            Intent intent = new Intent(this, RegisterActivity.class);
            startActivity(intent);
        });
    }

    private boolean hasPermissions() {
        int cameraPermission = ContextCompat.checkSelfPermission(this, android.Manifest.permission.CAMERA);
        int micPermission = ContextCompat.checkSelfPermission(this, android.Manifest.permission.RECORD_AUDIO);
        return cameraPermission == PackageManager.PERMISSION_GRANTED && micPermission == PackageManager.PERMISSION_GRANTED;
    }

    private void requestPermissions() {
        ActivityCompat.requestPermissions(this, new String[]{
                android.Manifest.permission.CAMERA,
                Manifest.permission.RECORD_AUDIO
        }, REQUEST_CAMERA_MIC_PERMISSION);
    }
}