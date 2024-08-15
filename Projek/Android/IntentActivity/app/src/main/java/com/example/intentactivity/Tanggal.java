package com.example.intentactivity;

import android.app.DatePickerDialog;
import android.os.Bundle;
import android.view.View;
import android.widget.DatePicker;
import android.widget.EditText;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Calendar;

public class Tanggal extends AppCompatActivity {

    EditText etTanggal;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_tanggal);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        load();
    }
    public void load() {
        etTanggal = findViewById(R.id.etTanggal);
    }
    public void etTanggal(View view) {
        Calendar cal = Calendar.getInstance();

        int tgl = cal.get(Calendar.DAY_OF_MONTH);
        int bln = cal.get(Calendar.MONTH);
        int thn = cal.get(Calendar.YEAR);

        DatePickerDialog dtp = new DatePickerDialog(this, new DatePickerDialog.OnDateSetListener() {
            @Override
            public void onDateSet(DatePicker datePicker, int thn, int bln, int tgl) {
                etTanggal.setText(tgl+"-"+(bln+1)+"-"+thn);
            }
        }, thn, bln, tgl);
        dtp.show();
    }
}