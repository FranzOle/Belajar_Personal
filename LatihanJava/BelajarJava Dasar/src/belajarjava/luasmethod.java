package belajarjava;


public class luasmethod {

    public static int kali(int a, int b){
        return a*b;
    }
    public static void main(String[] args) {
        // TODO code application logic here
        int a=2;
        int jb,bj;
        jb =25;
        bj =5;
        if(a==5){
            System.out.print(bagi(jb,bj));
        }
        else{
            System.out.print(kali(jb,bj));
        }
            
        
    }
    
    public static int bagi(int a, int n){
      return a/n;  
    }
    
}
