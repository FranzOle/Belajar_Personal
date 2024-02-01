#include <iostream>
#include <string>
#include <stdio.h>
#include <conio.h>
#include <vector>
#include <stdlib.h>
#include <time.h>

using namespace std;

string entrance(){
	return "Selamat datang di Restoran";
}

void Menu(){
	cout<<"=============================\n";
	cout<<"Silahkan Memesan :\n\n";
	cout<<"= 1.Makanan \n";
	cout<<"= 2.Minuman \n";
	cout<<"= 3.Camilan \n";
	cout<<"=============================\n";
}


int tot=0;
int disk=0;
int harga[20],jum[20],i,pal[20],sub[20];
  string jenis[20];

void Makanan(){
  cout<<"1. Bakso : 10.000 \n2. Mie Ayam : 12.000\n3.Nasi Goreng : 12.000\n4.Penyetan : 10.000\n ";
  cout<<"Pilih 0 untuk selesai \n\n";
  while(true){
  	cout<<"Pilihan : "; cin>>pal[i];
  		if(pal[i]==0){
		break;
	}
  	switch(pal[i]){
  		case 1:
  			jenis[i]="Bakso"; harga[i]=10000;
  		break;
  		case 2:
  			jenis[i]="Mie Ayam"; harga[i]=12000;
  		break;
  		case 3:
  			jenis[i]="Nasi Goreng"; harga[i]=12000;
  		break;
  		case 4:
  			jenis[i]="Penyetan"; harga[i]=10000;
	  }
	  cout<<endl;
	  cout<<jenis[i]<<endl;
	  cout<<"Harga : "<<harga[i]<<endl;
	  cout<<"Jumlah : "; cin>>jum[i];
	  cout<<endl;
	sub[i]=harga[i]*jum[i];
	i++;
  } cout<<endl;
  
 cout<<endl;
 getche();
 system("cls");
}

void Minum(){
	cout<<"1. Es Teh : 3.000 \n2. Es Jeruk : 4.000\n3.Es Tebu : 3.000\n4. Es Degan : 6.000\n ";
  cout<<"Pilih 0 untuk selesai \n\n";
  while(true){
  	cout<<"Pilihan : "; cin>>pal[i];
  		if(pal[i]==0){
		break;
	}
  	switch(pal[i]){
  		case 1:
  			jenis[i]="Es Teh"; harga[i]=3000;
  		break;
  		case 2:
  			jenis[i]="Es Jeruk"; harga[i]=4000;
  		break;
  		case 3:
  			jenis[i]="Es Tebu"; harga[i]=3000;
  		break;
  		case 4:
  			jenis[i]="Es Degan"; harga[i]=6000;
  		break;
  		default:
  			jenis[i]="Tidak Valid"; harga[i]=0;
	  }
	  cout<<endl;
	  cout<<jenis[i]<<endl;
	  cout<<"Harga : "<<harga[i]<<endl;
	  cout<<"Jumlah : "; cin>>jum[i];
	  cout<<endl;
	sub[i]=harga[i]*jum[i];
	i++;
  } cout<<endl;
  
 cout<<endl;
 getche();
 system("cls");
}

void Gorengan(){
	cout<<"1. Tahu Isi: 1.000 \n2. Menjes : 1.000\n3. Ote-Ote : 1.500\n4. Bakwan : 2.000\n ";
  cout<<"Pilih 0 untuk selesai \n\n";
  while(true){
  	cout<<"Pilihan : "; cin>>pal[i];
  		if(pal[i]==0){
		break;
	}
  	switch(pal[i]){
  		case 1:
  			jenis[i]="Tahu Isi"; harga[i]=1000;
  		break;
  		case 2:
  			jenis[i]="Menjes"; harga[i]=1000;
  		break;
  		case 3:
  			jenis[i]="Ote-Ote"; harga[i]=1500;
  		break;
  		case 4:
  			jenis[i]="Bakwan"; harga[i]=2000;
	  }
	  cout<<endl;
	  cout<<jenis[i]<<endl;
	  cout<<"Harga : "<<harga[i]<<endl;
	  cout<<"Jumlah : "; cin>>jum[i];
	  cout<<endl;
	sub[i]=harga[i]*jum[i];
	i++;
  } cout<<endl;
  
 cout<<endl;
 getche();
 system("cls");
}

void Pgr(){
	int n;                                                      
   	cout<<"Pesan yang mana ? : ";
   	cin>>n;
   	if(n==1){
   		return Makanan();
	}
	if(n==2){
		return Minum();
	}
	if(n==3){
		return Gorengan();
	}
	
}

char status(){
	char n;
	cout<<"Ada Lagi ? \n"; cin>>n;
	return n=='y' ||n=='Y';
}

void TYakin(){
	int data,jumd;
	cout<<"Menghapus data ? \n"; 
	cout<<"Berapa Banyak data yang ingin dihapus ? "; cin>>jumd;
	
	cout<<"Data setelah dihapus \n\n";
	for(int k=0; k<i-jumd; k++){
		cout<<jenis[k];
		cout<<"Jumlah : "<<jum[k]<<endl;
		cout<<"Sub Harga : "<<sub[k];
	    cout<<endl;
	}
}

void Strukk(){
	char stats;
	cout<<"=======================\n";
	cout<<"Struk \n\n";
	for(int a=0; a<i; a++){
		cout<<a+1<<".";
		cout<<"Jenis : "<<jenis[a];
		cout<<endl;
		cout<<"Jumlah : "<<jum[a];
		cout<<endl;
		cout<<"Sub Harga : "<<sub[a];
		cout<<endl;
		tot+=sub[a];
	}cout<<"Totalnya adalah : "<<tot<<endl<<endl;
	cout<<"Yakin dengan pilihan ? "; cin>>stats;
	if(stats=='t' ||stats=='T'){
		return TYakin();
	}
	
}


void Diskon() {
getche();
  srand(time(NULL));
  int n=rand()%3; 
  float n1;
  switch(n){
  	case 0:
  		n1=0.05;
  	break;
  	case 1:
  		n1=0.1;
  	break;
  	case 2:
  		n1=0.15;
  	break;
  }
  cout<<"Selamat anda mendapat diskon sebesar : "<<n1*100<<"%"<<endl;
  disk=n1*tot;
  disk=tot-disk;
  cout<<"Harga Setelah diskon : "<<disk;
}

int Uji(int Xx){
	return Xx<disk;
}

int Menghitung(int bayar){
   	return bayar-disk;
}


const char hur[]{"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()-_=+><?/"};
int pjg=sizeof(hur);

void woi(){
	string user,pass,sar;
	srand(time(NULL));
	cout<<"Buat Username "; cin>>user;
	cout<<"Saran Password : ";
	for(int i=0; i<8; i++){
		cout<<hur[rand()%pjg];
	} cout<<endl;
	cout<<"Buat Password "; cin>>pass;
	
}

void Onlen(){
	string user,pass;
	int pas;
	char stat;
	cout<<"Sudah buat akun ?  (y/t)"; cin>>stat;
	if(stat=='t'){
		return woi();
	}
	cout<<"Username : "; 	cin>>user; 
	cout<<"Password : "; 	pas=getche();
	while(pas!=13){
		pass.push_back(pas);
		cout<<'x';
		pas=getch();
	}
	
	 
}

int main(){
	
	cout<<entrance();
	cout<<endl;
	getche();
Menu();

getche();
system("cls");
do{
	Pgr();
}while(status());
Strukk();
Diskon();
int bayar;
while(Uji(bayar)){
	cout<<"Masukkan Uang Anda : "; cin>>bayar;
}
cout<<"Kembalian Anda "<<Menghitung(bayar);
getche();

cout<<endl;
int n;
do{
cout<<"Metode Pembayaran \n";
cout<<"1.Kas \n";
cout<<"2.Online \n";
cout<<endl;

cin>>n;
switch(n){
	case 1:
		cout<<"Silahkan Bayar Kekasir ";
		getche(); system("cls");
		goto develop;
	break;
	
	case 2:
	Onlen();
	
	getche(); system("cls");
		goto develop;	
	break;
}}while(n<1 ||n>2); getche(); cout<<endl; 

develop:
	cout<<"Made by Lionel \n";

}

