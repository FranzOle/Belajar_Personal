
package latihanprojekjavasederhana;

import java.util.Arrays;
public class LatihanProjekJavaSederhana {
    
static void print(int []hasil)   {
      System.out.print(Arrays.toString(hasil));
  }

static void consolelog(int []var1){
    for(int a=var1.length-1; a>=0; a--){
        System.out.print(" "+var1[a]);
    }
}
    public static void main(String[] args) {
    int [] var1 = {2,3,1,2,9};
    int [] var2 = {3,5,6,2,1};
    int [] hasil = new int [var1.length];
    //Menambahkan array
    for(int i = 0; i<var1.length; i++){
        hasil[i] = var1[i] + var2[i];
    }
    
   print(hasil);
   System.out.println();
   System.out.println("==Sort Array==");
    print(var1);
   Arrays.sort(var1);
    print(var1);
    System.out.println();
    System.out.println("==Reverse Sort Array==");
    consolelog(var1);
    
 }
    
  
  
  
}
