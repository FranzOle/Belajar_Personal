#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>>
using namespace std;

int main(){
	cout<<"+++++++++++++++++++++ \n";
	cout<<" Restoran Bakso Onel \n";
	cout<<"+++++++++++++++++++++ \n";
	getch();
	system("cls");
	
	cout<<" ======================================== \n";
	cout<<" ========================================== \n";
	cout<<" PROGRAM PEGAWAI KASIR 'Restoran Bakso Onel' \n";
	cout<<" ========================================== \n";
	cout<<" ======================================== \n";
	getche();
	system("cls");
	
	kunci:
	string name;
	string pass;
	cout<<"Masukkan username : "; cin>>name;
	cout<<"Masukkan Password :"; cin>>pass;
	system("cls");
	if(pass=="onelganteng"){
	
	cout<<"====== MENU ===== \n\n";
	cout<<"1. Bakso Urat \n";
	cout<<"2. Bakso Tetelan \n";
	cout<<"3. Bakso Udang \n";
	cout<<"4. Bakso Campur \n";
	getche();
	system("cls");
	
    int pilih[100],jumlah[100],sub_total[100],harga[100];
	string menu[100];
	int total_bayar;
	int i=0;
	bool selesai=false;
    cout<<"Tekan 0 untuk selesai \n";
	while(selesai==false){
    	
    	cout<<"Pilih Menu : ";
    	cin>>pilih[i];
    	
    	if (pilih[i]<=4){
    		
    		if (pilih[i]==0){
    			selesai=true;
			}else {
				switch (pilih[i]){
		    		case 1 : menu[i]="Bakso Biasa       "; harga[i]=12000; break;
		    		case 2 : menu[i]="Bakso Tetelan     "; harga[i]=15000; break;
		    		case 3 : menu[i]="Bakso Udang       "; harga[i]=12000; break;
		    		case 4 : menu[i]="Bakso Campur       "; harga[i]=12000; break;
		    		default : menu[i]="";harga[i]=0;
				}
				
				cout<<"Jumlah Porsi "<<menu[i]<<" : ";
		    	cin>>jumlah[i];
		    	cout<<endl;
		    	
		    	sub_total[i]=jumlah[i]*harga[i];
		    	
		    	total_bayar+=sub_total[i];
	    		i++;
			}
		} else {
			cout<<"Menu yang dipilih tidak sesuai"<<endl;
			cout<<endl;
		}
	} system("cls");
	cout<<endl;
	cout<<"                  PEMBELIAN BAKSO SUKSES                     "<<endl;
	cout<<"No	Nama Menu    	  	Harga		Jumlah        Sub Total "<<endl;
	for (int a=0;a<i;a++){
		  cout<<a+1<<"	"<<menu[a]<<"	"<<harga[a]<<"		"<<jumlah[a]<<"		"<<sub_total[a]<<endl;
	} getche(); system("cls");
	
	

	cout<<"Total Bayar adalah Rp."<<total_bayar<<",00"<<endl;
	int uangpem;
	int disk;
	cout<<"Diskon Khusus Oktober";
	if(total_bayar>=100000){
		disk=total_bayar*0.1;
	
	int kurangan;
	kurangan=total_bayar-disk;
	cout<<"harga setelah diskon : "<<kurangan<<endl;
	cout<<"Masukkan uang pelanggan : "; cin>>uangpem;
	cout<<"Total Kembalian adalah : "<<uangpem-kurangan;
	getche();
	system("cls");
	goto braxy;
}
else{
	cout<<"Masukkan uang pelanggan : "; cin>>uangpem;
	cout<<"Total Kembalian adalah : "<<uangpem-total_bayar;
	getche();
	system("cls");
	goto braxy;
}}
   else{
   	cout<<"Password Salah ') \n";
   	getche();
   	system("cls");
   	goto kunci;
   }
   
	braxy:
		cout<<"Made by : Lionel Jevon \n";
		cout<<"      +++++___+++++            ";
	return 0;
}

