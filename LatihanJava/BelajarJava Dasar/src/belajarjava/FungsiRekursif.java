
package belajarjava;
import java.util.Scanner;

public class FungsiRekursif {

    private static int Rekursif(int n){
       if(n==1){
           return 1;
       }
       return n*Rekursif(n-1);
    }
    
    public static void main(String[] args) {
       Scanner objek = new Scanner(System.in);
       int n = objek.nextInt();
       int hasil = Rekursif(n);
       System.out.println(hasil);
    }
    
}
