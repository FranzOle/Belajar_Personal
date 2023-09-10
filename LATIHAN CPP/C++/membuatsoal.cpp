#include <string.h>
#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <conio.h>
using namespace std;

string username[1000],pasword[1000];
string soal2[1000];
string arrJaw[1000];
string jd;

void BuatSoal(int n){
	for(int i=0; i<n; i++){
	    getline(cin>> ws, soal2[i]);
	}
}


void BuatJawab(int x){
	cout<<"Buat Jawabanmu : \n";
	for(int j=0; j<x; j++){
		getline(cin>> ws, arrJaw[j]);
		cout << arrJaw[j] <<endl;
	}
	
}

void MariJawab(int j){
	srand(time(0));
	int forrand=j;
	string yourJaw[j];
	
	for(int i=0; i<j; i++){
		int temp=rand()%j;
		string rdn=soal2[i];
		soal2[i]=soal2[temp];
		soal2[temp]=rdn;	   
	}
	
	int skor=0;
	for(int a=0; a<j; a++){
		cout << soal2[a] <<" : \n";
	    getline(cin >> ws, yourJaw[a]);
	}
	cout << skor;
}
void SignIn(int Jk=1){
	int i=0;
	while(i<Jk){
		i++;
		cout << "Buat Username : "; cin >> username[i];
		cout << "Buat Password : "; cin >> pasword[i];
	}
}
int main(){
    int pil;
	cout << "===========  Selamat datang di pembuatan soal =========\n";
    cout << "===========            1.Buat Soal            ========= \n";
    cout << "===========            2.Jawab Soal           =========\n";
    cout << "===========            3.Credit               ========\n\n";
    cin >> pil;
	switch(pil){
		case 1:
	    SignIn();
	     int jsoal;
	      cout << "Buat Judul : "; cin >> jd;
          cout << "Jumlah Soal : "; cin >> jsoal;
          BuatSoal(jsoal);
          BuatJawab(jsoal);

	}

    
    
   /* cout << "Mau Menjawab Soal ? "; cin >> jawaban;
    if(jawaban=="Ya" ||jawaban=="y" ||jawaban=="ya"){
   MariJawab(jsoal);
	}*/
	
}
