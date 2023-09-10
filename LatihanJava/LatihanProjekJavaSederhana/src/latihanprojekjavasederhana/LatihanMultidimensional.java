
package latihanprojekjavasederhana;
import java.util.Scanner;
import java.util.Arrays;

public class LatihanMultidimensional {
    
    public static void main(String[] args) {
       Scanner objek = new Scanner(System.in);
       int n,i;
       System.err.println("Masukkan baris dan kolom");
       n = objek.nextInt();
       i = objek.nextInt();
       int [][] Array1 = new int[n][i];
       int [][] Array2 = new int[n][i];
       for(int ij=0; ij<n; ij++){
           for(int ji=0; ji<i; ji++){
               System.out.println("Masukkan array :");
               Array1[ij][ji] = objek.nextInt();
           }
       }
       for(int ij=0; ij<n; ij++){
           for(int ji=0; ji<i; ji++){
               System.out.print( Array1[ij][ji]+" ");
           }
           System.out.println();
       }
       
    }
    
    
    
}
