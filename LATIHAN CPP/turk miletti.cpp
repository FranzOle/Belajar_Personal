#include <iostream>
using namespace std;\
int main (){
	int a,b,c,d;
	int tot;
	cout<<"Masukkan jumlah pembelian anda : \n";
	cin>>a;
	cout<<"Masukkan jumlah pembelian anda : \n";
	cin>>c;
	cout<<"Masukkan jumlah pembelian anda : \n";
	cin>>d;
	tot=a+c+d;
	
	if (tot >=10000){
	 b=0.1*tot;
	}
	cout<<"Jumlah Pembelian anda adalah :"<<tot<<endl;
	cout<<"Potongan Anda adalah : "<<b<<endl;
	cout<<"Jumlah yang harus dibayar adalah :"<<tot-b<<endl;
	return 0;
	
}
