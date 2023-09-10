#include <iostream>
using namespace std;

void Myarr(int myarr[10]){
	int a=0;
	do{
		cout<<myarr[a];
		cout<<endl;
		a++;
	}while(a<10);
}

int main(){
	int youarr[10];
	for(int b=0; b<10; b++){
		cin>>youarr[b];
	} cout<<endl;
	Myarr(youarr);
}
