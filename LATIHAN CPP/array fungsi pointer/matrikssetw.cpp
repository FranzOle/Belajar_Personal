#include <iostream>
#include <iomanip>
using namespace std;
int main(){
	string array1[3][3];
	string array2[3][3];
	cout<<"Mastriks 1 : "<<endl;
	for(int a=0; a<3; a++){
		for(int b=0; b<3; b++){
			cout<<"Masukkan Indeks Ke "<<a<<" dan "<<b<<" : "; cin>>array1[a][b];
		}
	}
	cout<<endl;
	cout<<"Matriks 2 : "<<endl;
		for(int a=0; a<3; a++){
		for(int b=0; b<3; b++){
			cout<<"Masukkan Indeks Ke "<<a<<" dan "<<b<<" : "; cin>>array2[a][b];
		}
	}
	cout<<endl;
	
	cout<<"Matriks 1\n";
	for(int a=0; a<3; a++){
		for(int b=0; b<3; b++){
			cout<<array1[a][b]<<" ";
		
		}
		cout<<endl;
	}
	cout<<endl;
	cout<<"Matriks 2\n";
	for(int a=0; a<3; a++){
		for(int b=0; b<3; b++){
			cout<<array2[a][b]<<" ";
		
		}
		cout<<endl;
	}
}
