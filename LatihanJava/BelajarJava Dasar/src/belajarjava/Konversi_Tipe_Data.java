
package belajarjava;

public class Konversi_Tipe_Data {

    public static void main(String[] args) {
        //konversi tipe data dengan menggunakan method valueOf
        /*Deklarasi class dan tipe datanya misal
        int adalah Integer.valueOf(variabel)
        */
        String variabel ="200";
        int variabel2=Integer.valueOf(variabel);
        System.out.println(variabel2+10);
        //Konversi tipe data menggunakan method parse 
        /*Deklarasi sesuai dengan tipe nya*/
        String num="314";
        float i=Float.parseFloat(num);
        System.out.print(i);
    }
    
}
