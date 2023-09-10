#include <iostream>
using namespace std;
int main(){
	int jum[10],harga[10],pil[10],sub[10];
	int tot=0;
	int i=0;
	char jawab;
	while(true){
		cout<<"Pilih : ";
		cin>>pil[i];
		if(pil[i]==1){
			cout<<"Basko Ayam \n";
			harga[i]=10;
		}
	    else if(pil[i]==2){
			cout<<"Basko \n";
			harga[i]=20;
		}
		else if(pil[i]==3){
			cout<<"Basko Sapi \n";
			harga[i]=30;
		}
		cout<<"Jumlah : "; cin>>jum[i];
		sub[i]=jum[i]*harga[i];
		tot+=sub[i];
		cout<<"Mau Lagi ? "; cin>>jawab;
		if(jawab=='n'){
			break;
		}
		i++;	
	};
	cout<<"totalnya : "<<tot;
}
