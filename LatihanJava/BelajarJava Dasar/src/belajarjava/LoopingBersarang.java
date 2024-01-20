
package belajarjava;

public class LoopingBersarang {

    
    public static void main(String[] args) {
        //membuat segitiga dengan for loop
        for(int i=0; i<=5-1; i++){
            for(int j=0; j<i; j++){
                System.out.print("* ");
            }
            System.out.println();
    }
    
        for(int i=0; i<5; i++){
            for(int j=i; j<5; j++){
                System.out.print("* ");
            }
            System.out.println();
    }
}
}
