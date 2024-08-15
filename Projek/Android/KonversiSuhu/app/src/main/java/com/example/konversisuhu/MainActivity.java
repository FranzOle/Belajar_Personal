package com.example.konversisuhu;

import android.os.Bundle;
import android.view.View;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {

    Spinner spinner;
    EditText etNilai;
    TextView tvHasil;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        load();
    }

    public void load() {
        spinner = findViewById(R.id.spinner);
        etNilai = findViewById(R.id.etNilai);
        tvHasil = findViewById(R.id.tvHasil);
    }

//    public void isiSpinner(){
//        String[] isi = {"Celcius to Reamur", "Celcius to Fahrenheit", "Celcius to Kelvin"};
//        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, android.R.layout.simple_spinner_item,isi);
//        spinner.setAdapter(adapter);
//    }

    public void btnKonversi(View view) {
        String pilihan = spinner.getSelectedItem().toString();

//        System.out.println(pilihan);
        if (etNilai.getText().toString().equals("")) {
            Toast.makeText(this, "Isi Kosong", Toast.LENGTH_SHORT).show();
        } else {
            if (pilihan.equals("Celcius to Reamur")) {
                cToR();
            }
            if (pilihan.equals("Celcius to Fahrenheit")) {
                cTof();
            }
            if (pilihan.equals("Celcius to Kelvin")) {
                cTok();
            }
            if (pilihan.equals("Reamur to Celcius")) {
                rToc();
            }
            if (pilihan.equals("Reamur to Celcius")) {
                rTof();
            }
        }
    }

    public void cToR() {
        double suhu = Double.parseDouble(etNilai.getText().toString());
        double hasil = (4.0 / 5.0) * suhu;
        tvHasil.setText(hasil + "");
    }

    public void cTof() {
        double suhu = Double.parseDouble(etNilai.getText().toString());
        double hasil = (9.0 / 5.0) * suhu + 32;
        tvHasil.setText(hasil + "");
    }

    public void cTok() {
        double suhu = Double.parseDouble(etNilai.getText().toString());
        double hasil = suhu + 273;
        tvHasil.setText(hasil + "");
    }

    public void rToc() {
        double suhu = Double.parseDouble(etNilai.getText().toString());
        double hasil = (5.0 / 4.0) * suhu;
        tvHasil.setText(hasil + "");
    }

    public void rTof() {
        double suhu = Double.parseDouble(etNilai.getText().toString());
        double hasil = (9.0 / 4.0) * suhu + 32;
        tvHasil.setText(hasil + "");

    }
}