#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>>
using namespace std;



void Bakso2(){
	cout<<" ======================================== \n";
	cout<<" ========================================== \n";
	cout<<" PROGRAM PEGAWAI KASIR 'Restoran Bakso Onel' \n";
	cout<<" ========================================== \n";
	cout<<" ======================================== \n";
	getche();
	system("cls");
}

void Bakso3(){
	int jum[100],harga[100],sub[100],tot;
	string jen[100];
	string lanj;
	
int x=0;
cout<<"Ketik 'End' untuk mengakhiri || Ketik keyword sembarang untuk lanjut \n\n";
while(true){
	cout<<"No "<<x+1<<".";
	cout<<"Jenis Bakso    : "; cin>>jen[x];
	cout<<"Jumlah Pesanan : "; cin>>jum[x];
	cout<<"Harga Bakso    : "; cin>>harga[x];
	cin>>lanj;
	if(lanj=="End" ||lanj=="end"){
		break;
	}
	
	sub[x]=harga[x]*jum[x];
	tot+=sub[x];
	x++;
}getche(); system("cls");
cout<<"Total Semua Pesanan Adalah : "<<tot;
int uang,disk,krg,kembali;
if(tot>=100000){
cout<<"Diskon Khusus Bulan Baru \n";
disk=tot*0.1; 
}
else{
	disk=0;
}
cout<<"Diskon : "<<disk;
cout<<"Harga yang harus dibayar : "<<tot-disk;
cout<<"Uang Pembeli : "<<uang;
cout<<"Kembalian adalah : "<<uang-(tot-disk);
getche(); system("cls");
}


int main(){
	Bakso2();
	
	kunci:
	string name;
	string pass;
	cout<<"Masukkan username : "; cin>>name;
	cout<<"Masukkan Password :"; cin>>pass;
	system("cls");
	if(pass=="onelganteng"){
		Bakso3();
	}
	else {
		cout<<"Password salah!!"<<endl;
		goto kunci;
	}
	
	cout<<"Designed by Lionel J\n";
	cout<<"====================\n";
	
	
	
}
