package com.example.sqlitedatabase;

public class Barang {

    private String idbarang, barang, stok, harga;

    public Barang(String idbarang, String barang, String stok, String harga) {
        this.idbarang = idbarang;
        this.barang = barang;
        this.stok = stok;
        this.harga = harga;
    }

    public String getIdbarang() {
        return idbarang;
    }

    public void setIdbarang(String idbarang) {
        this.idbarang = idbarang;
    }

    public String getBarang() {
        return barang;
    }

    public void setBarang(String barang) {
        this.barang = barang;
    }

    public String getStok() {
        return stok;
    }

    public void setStok(String stok) {
        this.stok = stok;
    }

    public String getHarga() {
        return harga;
    }

    public void setHarga(String harga) {
        this.harga = harga;
    }
}
