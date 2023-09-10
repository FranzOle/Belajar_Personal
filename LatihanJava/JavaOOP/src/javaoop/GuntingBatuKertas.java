
package javaoop;
import java.util.Random;
import java.util.Scanner;

public class GuntingBatuKertas {

    static String [] kode ={"Gunting","Batu","Kertas"};
    
    public static void main(String[] args) {
        
      System.out.println("\t Selamat Datang di game gunting batu kertas : ) ");
      Scanner input = new Scanner(System.in);
      do{
       System.out.println("\t pilihlah : 1.Gunting 2.Batu 3.Kertas \t");
       System.out.print("Masukkkan pilihan : ");
       String pilPlayer1 = input.nextLine();
       int pilPlayer = Integer.parseInt(pilPlayer1);
       Random rand = new Random();
       
       int cpu = (rand.nextInt(3))+1;
      
       String tmp = tampilan(pilPlayer);
       String tjk = tampilan(cpu);
       System.out.println("Anda memilih : "+tmp);
       System.out.println("Lawan memilih : " + tjk);
       SystemGame obj = new SystemGame( cpu, pilPlayer);
       String hasil = obj.Kondisi();
        System.out.println("Anda : "+hasil );
      }while(true);
    }
    
   static String tampilan(int par){
        switch (par) {
            case 1:
                return kode[0];
            case 2:
                return kode[1];
            case 3:
                return kode[2];
            default:
                return "Tidak Valid ";
        }
    }
    
    
}

class SystemGame{
    int cpu,ply;
    int []ml = new int[3];
   public SystemGame(int cpu, int ply){
    this.cpu = cpu;
    this.ply = ply;
}
   protected void MachineLearning(int ply){
        switch (ply) {
            case 1:
                this.ml[0]++;
                break;
            case 2:
                this.ml[1]++;
                break;
            case 3:
                this.ml[2]++; 
                break;
            default:
                break;
        }
   }
   String Kondisi(){
       if(ply==1){
           if(cpu==2){
               return "Kalah";
           }
           else if(cpu ==3){
               return "Menang";
           }
       }
       if(ply==2){
           if(cpu==3){
               return "Kalah";
           }
           else if(cpu ==1){
               return "Menang";
           }
       }
       
       if(ply==3){
           if(cpu==1){
               return "Kalah";
           }
           else if(cpu ==2){
               return "Menang";
           }
       }
       
       if(ply == cpu){
           return "Seri";
       }
        return null;
   }
   
   
}

 