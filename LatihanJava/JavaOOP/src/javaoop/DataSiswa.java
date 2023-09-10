
package javaoop;
import java.util.Scanner;

class ObjekSiswa {
    static String negara = "Indonesia";
    private int umur;
    private String nama;
    private String smk;
    ObjekSiswa(String nama,int umur,String smk){
      this.nama = nama;
      this.smk = smk;
      this.umur=umur;
      
    }
    
    public String GetNama(){
       return this.nama;
    }
    public int GetUmur(){
       return this.umur;
    }
    
    void Show(){
        System.out.println("Nama Anda : "+ nama);
        System.out.println("Umur : " +umur);
        System.out.println("Asal Sekolah : " + smk);
        System.out.println(negara);
    }
    
    public String Jjohan(){
        return nama + " Kamu Ganteng";
    }
}


public class DataSiswa {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("Selamat datang di program Siswa");
        int user;
 
        ObjekSiswa nando = new ObjekSiswa("Nando",16,"Smkn 2");
        nando.Show();
        System.out.println();
        ObjekSiswa reno = new ObjekSiswa("Moreno",15,"Smkn 10");
        reno.Show();
       reno.Jjohan();
       
      
       int vr1 =variabel(10);
       System.out.println(vr1);
       int nilai = Fungsi(20);
       System.out.println(nilai);
       
       String nndo = "abdillah ";
  
    
}
    
    public static int variabel(int nilai){
        return nilai +5;
    }
   public static int Fungsi(int nilai){
      
       return nilai;
   }

}
