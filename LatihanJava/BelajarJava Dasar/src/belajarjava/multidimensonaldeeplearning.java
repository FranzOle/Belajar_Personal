
package belajarjava;

import java.util.Arrays;

public class multidimensonaldeeplearning {

    public static void main(String[] args) {
        //ragged array
        int [][]jg = {{10,11},{14},{15,16,17,18}};
        
        for (int i = 0; i < jg.length; i++) {
            for (int j = 0; j < jg[i].length; j++) {
                System.out.print(jg[i][j]+" ");
            }
            System.out.println();
        }
        
        System.out.println(Arrays.deepToString(jg));
    }
    
}
