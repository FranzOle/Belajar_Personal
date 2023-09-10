#include <iostream>
#include <string>
using namespace std;

int n;
string soal[10000];
void BuatSoal(){
	cout<<"Selamat datang di pembuatan soal : \n";
	cout<<"Masukkan Jumlah soal : "; cin>>n; cout<<endl;
}


	
void Tampilkan(){
   for(int a=0; a<n; a++){
     cin>>soal[a];
	}
	
	 for(int b=0; b<n; b++){
    	cout<<b+1<<". "<<soal[b]<<endl;
	}
}


int main(){
	BuatSoal();
	Tampilkan();
	return 0;
}
