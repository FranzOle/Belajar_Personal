#include <iostream>
using namespace std;

int main(){
	/*
	cout<<"Grade Nilai \n";
	int nilai;
	char grade[4]{'A','B','C','D'};
	string status="Grade Anda : ";
	uji:
		cout<<"Masukkan Nilai Anda untuk mendapatkan grade nilai : "; cin>>nilai;
		if(nilai>=0 &&nilai<=100){
		
		if(nilai>=80 &&nilai<=100){
			cout<<status<<grade[0];
		}
		else if(nilai>=70 &&nilai<=79){
			cout<<status<<grade[1];
		}
		else if(nilai>=60 &&nilai<=69){
			cout<<status<<grade[2];
		}
		else{
			cout<<status<<grade[3];
		}
		}
		else{
			cout<<"Nilai Tidak Valid \n";
			goto uji;
		}*/
		int i;
		cin>>i;
	for (int b=0; b<i; b++ ) {
    for (int c=b; c<i; c++) {
    	cout<<" ";
		}
	for(int d=0; d<=b; d++){
		cout<<"+ ";
	}
	cout<<endl;
	}

}


