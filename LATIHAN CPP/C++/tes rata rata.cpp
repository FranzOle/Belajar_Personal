#include <iostream>
using namespace std;

int main(){
	float nilai[10],rpl[10],mat[10],phy[10];
	string nme[10],kelas;
	float tot=0.0,ratamat=0.0,ratarpl=0.0,rataphy=0.0;
	int jm;
	cout<<"Jumlah Siswa : "; cin>>jm;
	cout<<endl<<endl;
	ulang:
	for(int x=0; x<jm; x++){
		cout<<"Nama : "; cin>>nme[x];
		cout<<"Nilai Pemograman : "; cin>>rpl[x];
		cout<<"Nilai Matematika : "; cin>>mat[x];
		cout<<"Nilai Fisika     : "; cin>>phy[x];
		cout<<endl;
		nilai[x]=(rpl[x]+mat[x]+phy[x])/3;
		tot+=nilai[x];
		ratamat+=mat[x]/jm;
		ratarpl+=rpl[x]/jm;
		rataphy+=phy[x]/jm;
	
	}
	for(int i=0; i<jm; i++){
		cout<<"Rata Rata "<<nme[i]<<" "<<nilai[i]<<endl;
	}cout<<endl;
	float elrata=tot/jm;
	cout<<"Rata Rata Nilai Matematika : "<<ratamat<<endl;
	cout<<"Rata Rata Nilai Pemograman : "<<ratarpl<<endl;
	cout<<"Rata Rata Nilai Fisika     : "<<rataphy<<endl;
	cout<<"Rata Rata Semua Nilai      : "<<elrata<<endl;
}
