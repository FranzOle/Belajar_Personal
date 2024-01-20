
package belajarjava;

import java.util.Arrays;
import java.util.Scanner;

public class operasi_pada_array {

    public static void main(String[] args) {
        // TODO code application logic here
        Scanner input = new Scanner(System.in);
        //merubah array kestring
        int [] yArr ={1,2,3,4,5};
        print(yArr);
        //kopi array
        int [] iArr = new int [5];
        print(iArr);
        //kopi dengan loop;
        for(int i=0; i<yArr.length; i++){
            iArr[i]=yArr[i];
        }
        print(iArr);
        //kopi dengan copyOf
        int [] iArr2;
        iArr2 = Arrays.copyOf(yArr, 5);
        print(iArr2);
        //kopi dengan copyOF range (dimana index dikurang a-1)
        int [] iArr3 = Arrays.copyOfRange(iArr, 2, 5);
        print(iArr3);
        //fill Array
        int [] jArr = new int[7];
        print(jArr);
        Arrays.fill(jArr, 03);
        print(jArr);
        //komparasi array
       
        int []ijArr ={8,9,10};
        System.out.println("Sort array ");
        int [] ykArr ={11,23,34,10,5,37};
        print(ykArr);
        Arrays.sort(ykArr);
        
        print(ykArr);
        
        //search array
        int []jiArr ={1,2,3,4,5,6,7};
        int user = input.nextInt();
        int pos = Arrays.binarySearch(jiArr, user)+1;
        System.out.println(user + " Ditemukan pada index ke : "+ pos);
        
       
    }
    private static void print(int [] Statdata){
        System.out.println(Arrays.toString(Statdata));
        
    }
}
