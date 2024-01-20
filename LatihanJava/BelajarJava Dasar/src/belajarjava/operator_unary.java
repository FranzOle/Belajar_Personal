/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package belajarjava;

/**
 *
 * @author TOSHIBA
 */
public class operator_unary {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int a = 10;
        
        System.out.println(++a);
        System.out.println(a++);
        
        int b = 10;
        
        System.out.println(--b);
        System.out.println(b--);
        
        boolean menikah = true;
        
        System.out.println(!menikah);
        
        boolean angka = 10 > 9;
        
        System.out.println(!angka);
    }
    
}
