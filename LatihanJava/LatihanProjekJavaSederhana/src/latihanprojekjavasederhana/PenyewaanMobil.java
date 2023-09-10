package latihanprojekjavasederhana;

import java.util.Scanner;

public class PenyewaanMobil {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        String [] namatipe = {"Brio","Avanza","Inova"};
       String nama;
       int Tipe,Hari,Harga = 0;
       System.out.println("Selamat datang di penyewaan mobil sederhana ! ");
      System.out.print("Masukkan nama anda : ");
      nama = input.nextLine();
 
        
      System.out.println("Jenis Mobil : ");
       for(int i=0; i<namatipe.length; i++){
            System.out.println((i+1)+". " + namatipe[i]);
       }
       do{
        System.out.print("Pilih sesuai nomer : "); Tipe = input.nextInt();
        switch(Tipe){
            case 1:
        Harga = 100000;
               break;
            case 2:
                Harga = 150000;
               break;
            case 3:
                Harga = 200000;
              break;
            default:
                System.err.print("Data yang diinputkan tidak valid ");
        }          
        }while(Tipe<1 ||Tipe>3);
      System.out.print("Mau menyewa berapa hari ? "); Hari = input.nextInt();
        int bayar = Harga *Hari;
        System.out.println(nama + ", Anda harus membayar : " + bayar);
        
        
       
    }
    
    
    
}
