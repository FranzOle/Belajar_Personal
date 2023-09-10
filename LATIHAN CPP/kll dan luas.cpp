#include <iostream>
#include <stdio.h>
using namespace std;
int main () {
cout<<"Selamat datang di program menghitung luas dan keliling lingkaran \n";
float r,k,l;
float d=2*r;
const float phi=3.14;
int x;
char nama[10];
char jawab;

printf("Masukkan Nama : \n");
gets(nama);
pilih:
	cout<<"1.Luas Lingkaran \n";
	cout<<"2.Keliling Lingkaran \n";
	cout<<" Pilihlah perhitungan : \n";cin>>x;
	if (x==1 ||x==2){
	
		if(x==1){
			printf("Masukkan Jari Jari :");
			cin>>r;
			l=r*r*phi;
			cout<<"Maka hasilnya adalah :"<<endl;
			cout<<l;		
		}
		else {
			printf("Masukkan jari jari : \n");
			cin>>r;
			k=d*phi;
			cout<<"Maka hasilnya adalah : \n";
			cout<<k;
			
			}
		}
	}
	
	

