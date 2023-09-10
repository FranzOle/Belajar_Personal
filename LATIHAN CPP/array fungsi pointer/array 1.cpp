#include <iostream>
using namespace std;

int main(){
	int angka[5]={1,2,3,4,5};
	cout<<"indeks ke 0: "<<angka[0]<<endl;
	cout<<"indeks ke 1: "<<angka[1]<<endl;
	cout<<"indeks ke 2: "<<angka[2]<<endl;
	cout<<"indeks ke 3: "<<angka[3]<<endl;
	cout<<"indeks ke 4: "<<angka[4]<<endl;
	cout<<endl;
	
	int angkas[5];
	  angkas[0]=1;
	  angkas[1]=2;
	  angkas[2]=3;
	  angkas[3]=4;
	  angkas[4]=5;
	  
	  for (int i=0; i<5; i++) {
	  	cout << "Indeks Array " <<i<< " adalah " <<angkas[i] << endl;
	  	
	  }
	
	
}
