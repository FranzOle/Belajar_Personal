#include <iostream>
#include <stdio.h>
using namespace std;
int main(){
cout<<"Selamat datang di program menghitung luas dan keliling persegi panjang persegi panjang \n";
int a,b;
int aa;
char jawab;
char nama [10];
double l,k;
cout<<"Siapakah namamu : \n";
gets(nama);
pil:
cout<<"1.) Luas Persegi Panjang \n";
cout<<"2.) Keliling Persegi Panjang \n"; 
cout<<"Masukkan Pilihanmu : \n";cin>>aa;
if (aa==1 ||aa==2){
	cout<<"Masukkan Panjang : \n";cin>>a;
	cout<<"Masukkan Lebar : \n";cin>>b;
	if (aa==1){
		l=a*b;
		printf("Hasilnya adalah : \n");
		cout<<l<<endl;
		printf("Mau Menghitung Lagi ? \n");
		printf("Jawab dengan huruf (Y/T) \n");
		cin>>jawab;
		if (jawab=='Y' ||jawab=='T'){
			if(jawab=='Y'){
				goto pil;
			}
			else {
				printf("Terimakasih :D \n");
			}
		}
	}
	else {
		k=2*(a+b);
		printf("Hasilnya adalah : \n");
		cout<<k<<endl;
		printf("Mau Menghitung Lagi ? \n");
		printf("Jawab dengan huruf (Y/T)");
		cin>>jawab;
		if (jawab=='Y' ||jawab=='T'){
			if(jawab=='Y'){
				goto pil;
			}
			else {
				printf("Terimakasih :D \n");
			}
		}
	}
}



}
