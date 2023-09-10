#include <iostream>
using namespace std;
int main (){
	bilangan:
	int bil;
	int var=0;
	cout<<"Program menentukan Bilangan Prima \n";
	cout<<"------------------------------------ \n";
	cout<<"Tentukan Bilanganmu :  \n";
	cin>>bil;
	if(bil>0 &&bil<=100){
		for(int varn=0; varn<=bil;varn++){
			if(bil%varn==0){
		var++;	}
		}
		if(var==2){
			cout<<bil<<"  Merupakan Bilangan Prima \n";
		}
		else{
			cout<<bil<<" Bukan Bilangan Prima \n";
		}
	}
	else{
		cout<<"Bilangan Anda TIDAK VALID :| \n";
	}
	goto bilangan;
	cout<<"----------------------------------- \n";
	cout<<"TERIMAKASIH :) \n";
	return 0;
}
