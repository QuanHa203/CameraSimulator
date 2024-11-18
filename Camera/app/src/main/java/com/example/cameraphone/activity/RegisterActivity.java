package com.example.cameraphone.activity;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;

import com.example.cameraphone.CallApi;
import com.example.cameraphone.R;
import com.example.cameraphone.handleP2P.FirestoreDbContext;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import java.lang.reflect.Type;
import java.util.Map;

import okhttp3.Response;

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
            String cameraName = editTextRegisterCameraName.getText().toString();
            String password = editTextRegisterPassword.getText().toString();

            if(cameraName.trim().length() == 0) {
                Toast.makeText(this, "Camera name không được bỏ trống", Toast.LENGTH_SHORT).show();
                return;
            }

            if(password.trim().length() == 0) {
                Toast.makeText(this, "Password không được bỏ trống", Toast.LENGTH_SHORT).show();
                return;
            }

            Response response = CallApi.onPostRegisterAsync(cameraName, password);
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

                Type type = new TypeToken<Map<String, String>>() {}.getType();
                Map<String, String> connectionCode = new Gson().fromJson(responseData, type);
                FirestoreDbContext.getInstance().createDocumentConnectionCode(connectionCode.get("connectionCode").trim());
                Toast.makeText(this, "Đăng ký tài khoản thành công", Toast.LENGTH_SHORT).show();

                Thread.sleep(2000);
                this.finish();
            }
            catch (Exception ex) {
                Toast.makeText(this, "Error: " + ex.getMessage(), Toast.LENGTH_SHORT).show();
            }
        });

        textViewRedirectToLoginActivity.setOnClickListener(view -> {
            finish();
        });
    }
}