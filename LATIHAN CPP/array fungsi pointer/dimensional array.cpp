#include <iostream>
using namespace std;

int main(){
	
	int jumlah,pot;
cout<<"Jumlah uang anda";
cin>>jumlah;
if(jumlah>=1000000){
pot=0.1*jumlah;
}
else{
pot=0;
}
cout<<"Potongan Anda "<<pot;
cout<<"Harga setelah dipotong : "<<jumlah-pot;
}
