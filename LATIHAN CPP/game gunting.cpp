#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <string>

using namespace std;

enum var{
	rusdi,
	rizky,
	rehan
};

string Pemil(var hah){
	switch (hah){
		case rusdi:
			return "Batu";
		break;
		case rizky:
			return "Gunting";
		break;
		case rehan:
			return "Kertas";
	}
}

string Hasil(var hum, var kom){
	if(hum==rusdi){
		if(kom==rehan){
			cout<<"Lawan Menang";
		}
		else if(kom==rizky){
			cout<<"Kamu Menang";
		}
	}
	else if(hum==rizky){
		if(kom==rusdi){
			cout<<"Lawan Menang";
		}
		else if(kom==rehan){
			cout<<"Kamu Menang";
		}
		
	}
	else if(hum==rehan){
		if(kom==rusdi){
			cout<<"Kamu Menang";
		}
		else if(kom==rizky){
			cout<<"Lawan Menang";
		}
	}
	else if(hum==kom){
		cout<<"Seri !";
	}
}

int main(){
	int pilx,cpux;
	var cpu;
	var ply;
	
	srand(time(0));
	cout<<"Game BGK \n \n";
	cout<<"Pilihan : \n";
	cout<<" 1.Batu\n 2.Gunting\n 3.Kertas\n\n";
	cout<<"Pilih Yang Mana : "; cin>>pilx;
	switch(pilx){
		case 1:
			ply=rusdi;
		break;
		case 2:
			ply=rizky;
		break;
		case 3:
			ply=rehan;
	}
	cpux=rand()%3;
	if(cpux==0){
		cpu=rusdi;
	}
	else if(cpux==1){
		cpu=rizky;
	}
	else if(cpux==2){
		cpu=rehan;
	}
	cout<<"Lawan Memilih : "<<Pemil(cpu);
	cout<<endl;
	cout<<"Kamu Memilih  : "<<Pemil(ply);
	cout<<endl;
	Hasil(ply,cpu);
	
	
}
