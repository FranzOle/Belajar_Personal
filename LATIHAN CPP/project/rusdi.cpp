#include <iostream>
#include <string>
#include <stdlib.h>
#include <time.h>
#include <string>

using namespace std;

enum sjt{
	rusdi,
	rizky,
	rehan
	
};

string uiCPU(sjt hum){
	switch(hum){
		case rusdi:
			return "Rusdi";
		break;
		case rizky:
			return "Rizky";
		break;
		case rehan:
			return "Reham";
	}
}

string Hasil(sjt hum, sjt kom){
	if(hum==rusdi){
		if(kom==rizky){
			cout<<"Lawan Menang";
		}
		else if(kom==rehan){
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
}

int main(){

	int pil,cpux;
	sjt ply;
	sjt cpu;
	srand(time(0));
	string jawab;
	
	do{
	cout<<" 1.Rusdi\n 2.Rizky\n 3.Rehan\n\n";
	cout<<"Pilih Yang Mana : ";
	cin>>pil;
	if(pil==1){
    	ply=rusdi;}
    else if(pil==2){
	    ply=rizky;}
    else if(pil==3){
	    ply=rehan;}
    else {
	    ply=rusdi;}
	
	cpux=rand()%3;
	if(cpux==0){
	    cpu=rusdi;}
    else if(cpux==1){
		cpu=rizky;}
    else if(cpux==2){
		cpu=rehan;}
	cout<<"Lawan Memilih : "<<uiCPU(cpu)<<endl;
	
	cout<<Hasil(ply,cpu);
	cout<<endl;
	cout<<"Main Lagi ? "; cin>>jawab;
	cout<<endl;	}while(jawab=="ya");
}
