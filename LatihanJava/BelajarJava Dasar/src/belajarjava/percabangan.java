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
public class percabangan {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        char grade ='A';
        switch(grade){
            case 'A':
                System.out.println("Sangat Bagus");
            break;
            case 'B':
                System.out.println("Biasa Saja");
            break;
            case 'C':
                System.out.println("Jelek");
            break;
            default:
                System.out.println("Tidak Valid");
        }
    }
    
}
