/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package latihanprojekjavasederhana;

import java.util.ArrayList;
import java.util.Scanner;

public class Kontak {
private String nama;
private String nomorTelepon;
private String email;

public Kontak(String nama, String nomorTelepon, String email) {
    this.nama = nama;
    this.nomorTelepon = nomorTelepon;
    this.email = email;
}

public String getNama() {
    return nama;
}

public void setNama(String nama) {
    this.nama = nama;
}

public String getNomorTelepon() {
    return nomorTelepon;
}

public void setNomorTelepon(String nomorTelepon) {
    this.nomorTelepon = nomorTelepon;
}

public String getEmail() {
    return email;
}

public void setEmail(String email) {
    this.email = email;
}

}


public class BukuKontak {
    private ArrayList<Kontak> kontak = new ArrayList<Kontak>();

    public void tambahKontak(Kontak kontak) {
        this.kontak.add(kontak);
        System.out.println("Kontak berhasil ditambahkan.");
    }

    public void hapusKontak(int index) {
        this.kontak.remove(index);
        System.out.println("Kontak berhasil dihapus.");
    }

    public void tampilkanKontak() {
        if (this.kontak.size() == 0) {
            System.out.println("Daftar kontak kosong.");
        } else {
            System.out.println("Daftar kontak:");
            for (int i = 0; i < this.kontak.size(); i++) {
                Kontak kontak = this.kontak.get(i);
                System.out.println(i + 1 + ". " + kontak.getNama() + " (" + kontak.getNomorTelepon() + ", " + kontak.getEmail() + ")");
            }
        }
    }
   public void ubahKontak(int index, Kontak kontakBaru) {
    if(this.kontak.size()==0){
      System.out.println("Tidak ada yang bisa diubah");
    }
    else{
    this.kontak.set(index, kontakBaru);
    System.out.println("Kontak berhasil diubah.");
       }
    }

    public void jalankan() {
        Scanner input = new Scanner(System.in);
        boolean kontrolflow = true;
        while (kontrolflow) {
            System.out.println("Menu:");
        
           System.out.println("1. Tampilkan daftar kontak");
           
            System.out.println("2. Tambah kontak baru");
            System.out.println("3. Hapus kontak");
            System.out.println("4. Ubah Kontak");
            System.out.println("5. Keluar");
            System.out.print("Pilih menu: ");
            int pilihan = input.nextInt();
            input.nextLine();
            switch (pilihan) {
            case 1:
                tampilkanKontak();
                break;
            case 2:
                System.out.print("Nama: ");
                String nama = input.nextLine();
                System.out.print("Nomor telepon: ");
                String nomorTelepon = input.nextLine();
                System.out.print("Email: ");
                String email = input.nextLine();
                Kontak kontakBaru = new Kontak(nama, nomorTelepon, email);
                tambahKontak(kontakBaru);
                break;
            case 3:
                tampilkanKontak();
                System.out.print("Pilih nomor kontak yang ingin dihapus: ");
                int indeks = input.nextInt();
                input.nextLine();
                hapusKontak(indeks - 1);
                break;
            case 4:
              tampilkanKontak();
              int eIndex = input.nextInt();
              
         System.out.print("Nama: ");
         String nama2 = input.nextLine();
         System.out.print("Nomor telepon: ");
         String nomerHandphone2 = input.nextLine();
         System.out.print("Email: ");
    String email2 = input.nextLine();
            Kontak kontakedit = new Kontak(nama2,nomerHandphone2,email2);
             ubahKontak(eIndex-1,kontakedit);
             break;
             case 5:
               kontrolflow=false;
               break;
            }
         }
      
    }
  }


public class Main{
  public static void main(String []args){
    BukuKontak open = new BukuKontak();
    open.jalankan();
  }
}import java.util.ArrayList;
import java.util.Scanner;

public class Kontak {
private String nama;
private String nomorTelepon;
private String email;

public Kontak(String nama, String nomorTelepon, String email) {
    this.nama = nama;
    this.nomorTelepon = nomorTelepon;
    this.email = email;
}

public String getNama() {
    return nama;
}

public void setNama(String nama) {
    this.nama = nama;
}

public String getNomorTelepon() {
    return nomorTelepon;
}

public void setNomorTelepon(String nomorTelepon) {
    this.nomorTelepon = nomorTelepon;
}

public String getEmail() {
    return email;
}

public void setEmail(String email) {
    this.email = email;
}

}


public class BukuKontak {
    private ArrayList<Kontak> kontak = new ArrayList<Kontak>();

    public void tambahKontak(Kontak kontak) {
        this.kontak.add(kontak);
        System.out.println("Kontak berhasil ditambahkan.");
    }

    public void hapusKontak(int index) {
        this.kontak.remove(index);
        System.out.println("Kontak berhasil dihapus.");
    }

    public void tampilkanKontak() {
        if (this.kontak.size() == 0) {
            System.out.println("Daftar kontak kosong.");
        } else {
            System.out.println("Daftar kontak:");
            for (int i = 0; i < this.kontak.size(); i++) {
                Kontak kontak = this.kontak.get(i);
                System.out.println(i + 1 + ". " + kontak.getNama() + " (" + kontak.getNomorTelepon() + ", " + kontak.getEmail() + ")");
            }
        }
    }
   public void ubahKontak(int index, Kontak kontakBaru) {
    if(this.kontak.size()==0){
      System.out.println("Tidak ada yang bisa diubah");
    }
    else{
    this.kontak.set(index, kontakBaru);
    System.out.println("Kontak berhasil diubah.");
       }
    }

    public void jalankan() {
        Scanner input = new Scanner(System.in);
        boolean kontrolflow = true;
        while (kontrolflow) {
            System.out.println("Menu:");
        
           System.out.println("1. Tampilkan daftar kontak");
           
            System.out.println("2. Tambah kontak baru");
            System.out.println("3. Hapus kontak");
            System.out.println("4. Ubah Kontak");
            System.out.println("5. Keluar");
            System.out.print("Pilih menu: ");
            int pilihan = input.nextInt();
            input.nextLine();
            switch (pilihan) {
            case 1:
                tampilkanKontak();
                break;
            case 2:
                System.out.print("Nama: ");
                String nama = input.nextLine();
                System.out.print("Nomor telepon: ");
                String nomorTelepon = input.nextLine();
                System.out.print("Email: ");
                String email = input.nextLine();
                Kontak kontakBaru = new Kontak(nama, nomorTelepon, email);
                tambahKontak(kontakBaru);
                break;
            case 3:
                tampilkanKontak();
                System.out.print("Pilih nomor kontak yang ingin dihapus: ");
                int indeks = input.nextInt();
                input.nextLine();
                hapusKontak(indeks - 1);
                break;
            case 4:
              tampilkanKontak();
              int eIndex = input.nextInt();
              
         System.out.print("Nama: ");
         String nama2 = input.nextLine();
         System.out.print("Nomor telepon: ");
         String nomerHandphone2 = input.nextLine();
         System.out.print("Email: ");
    String email2 = input.nextLine();
            Kontak kontakedit = new Kontak(nama2,nomerHandphone2,email2);
             ubahKontak(eIndex-1,kontakedit);
             break;
             case 5:
               kontrolflow=false;
               break;
            }
         }
      
    }
  }


public class Main{
  public static void main(String []args){
    BukuKontak open = new BukuKontak();
    open.jalankan();
  }
}
