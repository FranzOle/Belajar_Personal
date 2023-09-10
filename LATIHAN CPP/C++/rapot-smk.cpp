#include <iostream>
#include <conio.h>
#include <stdlib.h>
#include <time.h>
#include <string>
using namespace std;

string mapel;
string kelas[5]={"RPL","DKV","TKJ","PPLG","BDM"};
int vote[1250];
int n;
int vot1=0,vot2=0;
int x=0;
int i=0;


int Vote(){
	string kelaas;
	
	do{
	i++;
	cout<<"Kelas : "; cin>>kelaas;
	for(int b=0; b<5; b++){
		if(kelaas==kelas[b]){
			x=b+1;
		}
	}

	}  while(i<3);
	return x;
}

void voting(){
	cout<<"Jumlah Siswa : "; cin>>n;
	
	for(int i = 0; i < n; i++){
		cout<<"Masukkan Pilihan : "; cin>>vote[i];
		if(i==1){
			vot1++;
		}
		else{
			vot2++;
		}
	}
}
void VoteAcak(){
	srand(time(0));
	for(int c=0; c<1250-n; c++){
		vote[c]=1+(rand()%3);
		if(vote[c]==1){
			vot1++;
		}
		else {
			vot2++;
		}
	}
}

void Tampilkan(){
	cout<<"jumlah Suara Pasangan 1 : "<<vot1;
	cout<<endl;
	cout<<"Jumlah Suara Pasangan 2 : "<<vot2;
}
string Status(){
	if(vot1>vot2)
	 return "Pasangan Satu Menang !";
	else
	return "Pasangan Dua Menang ! ";
}

int main(){
	cout<<"Pemilihan Ketua Osis SMK teknologi dan komputasi "<<endl;
	

	if (Vote()==0) {
		goto salah;
	}
	voting();
	VoteAcak();
	Tampilkan();
	cout<<endl;
	cout<<Status();
	salah :
		cout << "Salah!";
	return 0;
}
