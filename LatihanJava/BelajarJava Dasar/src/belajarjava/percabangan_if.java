
package belajarjava;

import java.util.Scanner;


public class percabangan_if {
    //keyword "if" digunakan untuk sebuah kondisi yang bercabang
    public static void main(String[] args) {
        //perintah2 dalam if akan dieksekusi jika kondisinya bernilai TRUE
        float nilai;
        Scanner input = new Scanner(System.in);
        System.out.print("Masukkan nilaimu : ");
        nilai = input.nextFloat();
        /*kode if dibawah ini akan dieksekusi jika kondisinya true 
        dengan var nilai lebih besar dari 90 (contoh saja) */
        if(nilai>=90){
            System.out.println("Kamu Hebat");
        }
        else if(nilai>=80 && nilai>=70){
            System.out.println("Kamu Cukup tapi lebih banyak belajar");
        }//else if jika saat kondisi if pertama bernilai false
        else{
            System.out.print("Maaf nilai kamu kurang");
        }//else akan dieksekusi jika dua kondisi diatas bernilai false
    }
    
}
