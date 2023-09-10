#include <iostream>
using namespace std;

int main(){
	cout<<"=== Array 3 dimensi dengan tipe data string === \n\n";
   string huruf[2][4][2];
   
   
   
   cout<<"== input indeks == \n";
   for(int a=0; a<2; a++){
   	 for(int b=0; b<4; b++){
   	 	for(int c=0; c<2; c++){
   	 		cout<<"Masukkan data pada indeks ke : "<<a<<","<<b<<","<<c<<" : "; cin>>huruf[a][b][c];
			}
			cout<<endl;
		}
		cout<<endl;
   }cout<<endl;
   for(int a=0; a<2; a++){
   	 for(int b=0; b<4; b++){
   	 	for(int c=0; c<2; c++){
   	 		cout<<huruf[a][b][c]<<" ";
			}
			cout<<endl;
		}
		cout<<endl;
   }
   
   return 0;
}
