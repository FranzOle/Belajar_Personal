#include <iostream>
#include <stdlib.h>
#include <time.h>
#include <string.h>
using namespace std;

string status[3]={"Gunting","Batu","Kertas"};
string m[3]={"Kamu Menang Kali ini ! ","Lawan Menang Kali ini ","Seri ! "};

string statuS(int *p1, int *p2){
	if(*p1==1){
		if(*p2==2){
			return m[1];
		}
		else if(*p2==3){
			return m[0];
		}
	}
	if(*p1==2){
		if(*p2==3){
			return m[1];
		}
		else if(*p2==1){
			return m[0];
		}
	}
	if(*p1==3){
		if(*p2==1){
			return m[1];
		
		}
		else if(*p2==2){
			return m[0];
		}
	}
	if(*p1==*p2){
		return m[2];
	
	}
	else{
		return "Tidak valid";
	}
}

void CPU(int kom){
	string n;
	switch(kom){
		case 1:
			n=status[0];
		break;
		case 2:
			n=status[1];
		break;
		case 3:
			n=status[2];
		break;
	}
	cout<<n;
}

	int skor1,skor2,skor3;
	
int Skor(string V1){
	if(V1==m[0]){
		skor1++;
	}
	else if(V1==m[1]){
		skor2++;
	}
	else 
	 skor3++;
}

void SkorOutput(){
	cout << "Skor Kamu : " << skor1 << endl;
	cout << "Skor Komputer : " << skor2 <<endl;
}


int main(){
    bgk:
	srand(time(0));
    int player,comp=1+(rand()%3);
    string sta;
    int i=0;
    string Skorply,SkorKomp,SkorSeeri;
    do{
    cout << "Permainan Gunting Batu Kertas  \n\nPilihlah : 1. Gunting  2. Batu  3. Kertas  ";
	cin >> player;
 
    cout << "Lawan memilih "; CPU(comp); cout << endl;
    cout << "Kamu Memilih "; CPU(player);
    cout << "\n\n";
    
    string LiveScore=statuS(&player,&comp);
    cout<<statuS(&player,&comp)<<endl<<endl;
    Skor(LiveScore);
    SkorOutput();
    
    cout<<"Main Lagi : "; cin>>sta;
    }while(sta=="ya");
   
	return 0;
}
