#include <iostream>
using namespace std;
int main(){
	int r,pilih;
	double l,kll;
	char jawab;
	char nama[10];
	cout<<"Selamat Datang di Program mencari luas dan keliling lingkaran \n";
	cout<<"_________________________\n";
	cout<<"Pertama Masukkan NAMAMU : ";cin>>nama;
	pilihan:
		cout<<"1. Luas Lingkaran \n";
		cout<<"2. Keliling Lingkaran \n";
		cout<<"Masukkan Pilihanmu : \n";cin>>pilih;
		if (pilih==1 ||pilih==2){
			if(pilih==1){
				cout<<"Masukkan Jari-Jari : \n";cin>>r;
				if(r %7==0){
					l=(22*r*r)/7;
				}
				else{
					l=3.14*r*r;
				}
				cout<<"Hasillnya Adalah : "<<l<<endl;
				cout<<"Mau Menghitung lagi ? "<<endl;cin>>jawab;
				
					if(jawab=='Y'){
						goto pilihan;
					}
					
					else{
						cout<<"Terimakasih telah menggunakan program ini :) \n";
					}
				
			}
			else{
				cout<<"Masukkan Jari-Jari : \n";cin>>r;
				if(r %7==0){
					kll=(22*2*r)/7;
				}
				else{
					kll=2*3.14*r;
				}
				cout<<"Hasilnya Adalah : \n"<<kll;
				cout<<"Mau menghitung lagi ? \n";cin>>jawab;
				if(jawab=='Y'){
					goto pilihan;
				}
				else {
					cout<<"Makasih menggunakan program ini :) \n";
				}
			}
		}
		else{
			cout<<"Pilihlah 1-2";
		}
}
