 
package javaoop;
import java.util.Scanner;

class Orang{
    private static String nama;
    Orang(String nama){
        this.nama = nama;
    }
    
   public void Tampilkan(){
       System.out.println(nama);
   }
}

class Siswa{
    private static String sekolah;
   
    protected void SetSekolah(String sekolah){
        this.sekolah = sekolah;
    }
    
   protected  String GetSekolah(){
       return sekolah;
   }
}

class Rpl extends Siswa{
    String nama;
    public Rpl(String nama) {
        this.nama = nama;
    }
    
    public void Output (){
        System.out.println("Halo "+nama+" Kamu dari sekolah : "+super.GetSekolah());
    }
    
}
public class TestInheritancer {    
    public static void main(String[] args) {
        // TODO code application logic here
       
        String sekolah = "SMKN 2 Buduran ";
        Siswa murid = new Siswa();
        murid.SetSekolah(sekolah);
        
        Rpl student = new Rpl("Nando");
        Rpl student1 = new Rpl("Rifal");
        student.Output();
        student1.Output();
    }
    
}
