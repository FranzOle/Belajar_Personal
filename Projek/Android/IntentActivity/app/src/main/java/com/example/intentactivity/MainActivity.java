package com.example.intentactivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    EditText etbarang;

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
        etbarang = findViewById(R.id.etBarang);
    }

    public void btnPembelian(View view) {
        String barang = etbarang.getText().toString();
        Intent intent = new Intent(this, Pembelian.class);
        intent.putExtra("ISI", barang);
        startActivity(intent);
    }

    public void btnBarang(View view) {
        String barang = etbarang.getText().toString();
        Intent intent = new Intent(this, Barang.class);
        intent.putExtra("ISI", barang);
        startActivity(intent);
    }

    public void btnPenjualan(View view){
        Intent intent = new Intent(this, Penjualan.class);
        startActivity(intent);
    }

    public void btnTanggal(View view) {
        Intent intent = new Intent( this, Tanggal.class);
        startActivity(intent);

    }
}