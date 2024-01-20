import java.util.Scanner;
        
public class Main {

    public static void main(String[] args) {
      Scanner input = new Scanner(System.in);
      System.out.println("Masukkan brp angka ");
      int n;
      n = input.nextInt();
      //int n1 =Integer.valueOf(n);
      KiriBawah segitiga = new KiriBawah();
      KiriBawah v1 = new KiriBawah();
      v1.n = n;
      segitiga.Buat();
      
    }
}

class KiriBawah{
    public static int n;
    static void Buat(){
        for(int i=0; i<=n; i++){
            for(int j=0; j<i; j++){
                System.out.print("* ");
            }
            System.out.println(); 
        }
    }
}
