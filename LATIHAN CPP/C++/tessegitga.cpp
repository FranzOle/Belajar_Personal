#include <stdio.h>
#include <iostream>
using namespace std;
int main(){
	int x=1;
        while(x<=5){
               int y=1;
            while(y<x){
              y++;
              cout<<y<<" ";
            }
            printf("\n");
                x++;
        }
}
