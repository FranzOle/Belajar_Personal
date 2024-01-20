/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package belajarjava;
import java.util.Scanner;
/**
 *
 * @author TOSHIBA
 */
public class LatihanFibonacci {

    public static void main(String[] args) {
        Scanner InputUser = new Scanner(System.in);
        int n;
       System.out.print("Masukkan brp banyak : ");
        n = InputUser.nextInt();  
        Fibonacci(n);
    }
    
    static void Fibonacci(int n){
        long itr1 = 0;
        long itr2 =1;
        long jmlh = 0;
        for(int i=0; i<=n; i++){
            jmlh = itr1 +itr2;
            itr1 = itr2;
            itr2 = jmlh;
            System.out.println("Bilangan Fibonacci ke : " + i + " Adalah : " + jmlh);
        }
    }

    
}
