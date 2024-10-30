package com.example.cameraphone;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class RegisterActivity extends AppCompatActivity {
    private EditText editTextRegisterCameraName;
    private EditText editTextRegisterPassword;
    private TextView textViewRedirectToLoginActivity;
    private Button btnRegister;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_register);

        editTextRegisterCameraName = findViewById(R.id.editTextRegisterCameraName);
        editTextRegisterPassword = findViewById(R.id.editTextRegisterPassword);
        textViewRedirectToLoginActivity = findViewById(R.id.textViewRedirectToLoginActivity);
        btnRegister = findViewById(R.id.btnRegister);

        btnRegister.setOnClickListener(view -> {

        });

        textViewRedirectToLoginActivity.setOnClickListener(view -> {
            finish();
        });
    }
}