
package latihanprojekjavasederhana;
import java.util.Scanner;

class fibonacci_recursive {

   public static int Fibonacci(int n){
       if(n==0 ||n==1){
        return n;
                }
       else{
           return Fibonacci(n-1) +Fibonacci(n-2);
       }
   }
    public static void main(String[] args) {
        Scanner obj = new Scanner(System.in);
        
      int j;
     
 
        for(j=2; j<10; j++){
        System.out.print(Fibonacci(j)+" ");
        }
    }
}
   
      
