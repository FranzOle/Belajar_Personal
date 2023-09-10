#include <iostream>
using namespace std;
int main (){
	cout<<"Program IQ Lionel \n";
	int iq,umur;
	cout<<"Masukkan Umurmu :  ";cin>>umur;
	if (umur >=0 &&umur<=100){
		cout<<"Masukkan IQ-mu : \n";cin>>iq;
		if(umur <=15){
			if(iq >=120){
				cout<<"Anda Sangat Cerdas \n";
			}
			else if(iq >=100){
				cout<<"Anda diatas rata-rata \n";
			}
			else if(iq >=80){
				cout<<"Anda Rata-Rata \n";
			}
			else{
				cout<<"Dibawah rata-rata \n";
			}
		}
		else if(umur <=40){
			if(iq >=135){
				cout<<"Anda adalah salah satu manusia tercerdas dibumi\n";
			}
			else if (iq >=120){
				cout<<"Anda sangat cerdas \n";
			}
			else if(iq >=105){
				cout<<"Cukup cerdas \n";
			}
			else if(iq >=85){
				cout<<"Rata-rata \n";
			}
			else {
				cout<<"dibawah rata-rata \n";
			}
		}
		else if(umur <=95){
			if (iq >=160){
				cout<<"Anda Ilmuwan \n";
			}
			else if(iq>=100){
				cout<<"Rata-rata";
			}
			else {
				cout<<"dibawah rata rata \n";
			}
		}
		else{
			cout<<"Anda terlalu tua \n";
		}
	}
	
	else {
		cout<<"UMUR TIDAK VALID \n";
	}
	
}
