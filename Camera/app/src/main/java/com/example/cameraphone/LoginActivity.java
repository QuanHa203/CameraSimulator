package com.example.cameraphone;

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

public class LoginActivity extends AppCompatActivity {
    private static final int REQUEST_CAMERA_MIC_PERMISSION = 1;
    private EditText editTextLoginCameraName;
    private EditText editTextLoginPassword;
    private TextView textViewRedirectToRegisterActivity;
    private Button btnLogin;

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
            Intent intent = new Intent(this, MainActivity.class);
            this.finish();
            startActivity(intent);
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