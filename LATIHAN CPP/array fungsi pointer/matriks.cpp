#include <iostream>
#include <iomanip>
using namespace std;
int main(){
	int myarr[2][4];
	int youarr[2][4];
	cout<<"Inputkan Matriks ke-1 : "<<endl;
	for (int a=0; a<2; a++) {
		
		for (int b=0; b<4; b++) {
		cout<<"Masukkan Indeks " << "[" << a <<"]"<< "[" << b << "]" ;
		cin>>myarr[a][b];
		 
		}
		
	}
	cout << endl;
	cout << "Matriks ke 1" << endl;
	for (int a=0; a<2; a++) {
		
		for (int b=0; b<4; b++) {
		cout<<myarr[a][b]<<" ";
	
		}
		cout<<endl;
	}
	cout << endl;
	cout<<"Inputkan Matriks ke-2 : "<<endl;
	for (int a=0; a<2; a++) {
		
		for (int b=0; b<4; b++) {
		cout<<"Masukkan Indeks " << "[" << a <<"]"<< "[" << b << "]" ;
		cin>>youarr[a][b];
		 
		}
		
	}
	cout << endl << endl;
	cout << "Matriks ke 2" << endl;
	for (int a=0; a<2; a++) {
		
		for (int b=0; b<4; b++) {
		cout<<youarr[a][b]<<" ";
	
		}
		cout<<endl;
	}
	cout << endl;
	
	cout << "Penjumlahan Matriks 1 dan Matriks 2" << endl;
	cout<<"Matriks 1     Matriks 2     Hasil"<<endl;
		
		for (int b=0; b<4; b++) {
		cout<<myarr[0][b] << " ";
		if (b==3) {
			cout << "    ";
			goto matriks2;
		}
		 
		}
		
	matriks2:
		for (int x=0; x<4; x++) {
		cout<<youarr[0][x]<<" ";
		if (x==3) {
			cout << "    ";
			goto hasilrow1;
		}
	
		
		}
		
	hasilrow1:
		for(int a=0; a<4; a++){
			cout<<myarr[0][a]+youarr[0][a]<<" ";
			if(a==3){
				cout<< endl;
				goto row2;
			}
		}
		
	row2:
		for (int b=0; b<4; b++) {
		cout<<myarr[1][b] << " ";
		if (b==3) {
			cout << "    ";
			goto matriks3;
		}
		 
		}
		
	matriks3:
		for (int x=0; x<4; x++) {
		cout<<youarr[1][x]<<" ";
		if (x==3) {
			cout << "    ";
				goto hasilrow2;
		}
	
	
		}
		
	hasilrow2:
		for(int a=0; a<4; a++){
			cout<<myarr[1][a]+youarr[1][a]<<" ";
			if(a==3){
				cout<<endl;
			
			}
		}
	
	
}
