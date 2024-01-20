
package belajarjava;
import java.util.Arrays;
import java.util.Scanner;

public class arrayMultidimensi {

    public static void main(String[] args) {
       //deklarasi
       int [][] arr2d ={{1,2,3},
           {4,5,6}};
       print(arr2d);
       System.out.println();
       int [][] yArr={{1,2,3,4},{5,6,7,8},{9,8,7,6},{5,4,3,2},{1,2,3,4}};
       
       int [][] tmbh = new int[5][4];
    //mengeluarkan manual
    for(int i = 0; i<yArr.length; i++){
        for(int j=0; j<yArr[i].length; j++){
        System.out.print(yArr[i][j]+" ");
        }
        System.out.println();
    }
    System.out.println();
    print2d(yArr);
    }
    //foreach
    private static void print2d(int [][]datt){
        for(int []a: datt){
            for(int b:a){
                System.out.print(b+b+" ");
            }
            System.out.println();
        }
    }
    static void print(int [][]dat){
        System.out.print(Arrays.deepToString(dat));
    }
    
}
