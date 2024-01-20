
package belajarjava;

public class BelajarMethodsDenganReturnValueMaupunVoid {

    public static void Method1(){
        System.out.print("Ini adalah methods tanpa nilai balik ");
    }

    public static int Fungsi(){
        return 123;
    }
    public static void main(String[] args) {
     Method1();
     System.out.println();
     System.out.print("ini adalah fungsi dengan nilai balik atau bernilai : yang bernilai 123 : " + Fungsi());
    }
    
}
