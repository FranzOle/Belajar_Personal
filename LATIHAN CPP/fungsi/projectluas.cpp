#include <iostream>
#include <conio.h>
#include <stdio.h>
#include <stdlib.h>

using namespace std;

float LuasP(float s){
	float luas=s*s;
	return luas;
}

float KlP(float s){
	float kll=s*4;
	return kll;
}

void LuasPP(float p, float l){
	cout<<"Luasnya Adalah : "<<p*l;
}

void KllPP(float p, float l){
	float kll;
	kll=2*(p+l);
	cout<<"Kelilingnya Adalah : "<<kll;
}

float LuasLing1(float r){
	float luas=(22*r*r)/7;
	return luas;
}

float LuasLing2(float r){
	const double phi=3.14;
	float luas=phi*r*r;
	return luas;
}

float kllLing1(float r){
	float kll=(22*2*r)/7;
	return kll;
}

float kllLing2(float r){
     float kll=3.14*2*r;
     return kll;
}

float luasSg(float a, float t){
	float luas=(a*t)/2;
	return luas;
}

float kllSg(float a, float l, float s){
	float kll=a+l+s;
	return kll;
}


int main(){
	int pil;
	int p,l,s,a,r,sp,sk,t;
	string jaw,user,input;
	cout<<"Halo \n";
	getche(); system("cls");
	cout<<"Namamu : "; cin>>user;
	 system("cls");
	
	cout<<" == Selamat datang di program menghitung Luas & Keliling ==\n\n";
	cout<<" 1.Persegi\n 2.Persegi Panjang\n 3.Lingkaran\n 4.Segitiga\n";
	cout<<endl<<endl;
	
	do{
	pill:
	cout<<"Pilihanmu : ";
	cin>>pil;
	getche(); system("cls");
		switch(pil){
			case 1:
				cout<<"Masukkan Sisi  : "; cin>>a;
				cout<<endl<<endl;
				cout<<"Luasnya adalah     : "<<LuasP(a);
				cout<<endl;
				cout<<"Kelilingnya adalah :"<<KlP(a);
				break;
			case 2:
				cout<<"Masukkan Panjang : "; cin>>p;
				cout<<"Masukkan Lebar   : "; cin>>l;
				cout<<endl;
				LuasPP(p,l);
				cout<<endl;
				KllPP(p,l);
				break; 
			case 3:
				cout<<"Masukkan Jari-Jari : "; cin>>r;
				cout<<endl<<endl;
				cout<<endl;
				if(r%7==0){
					cout<<"Luas Lingkaran Adalah : "<<LuasLing1(r);
					cout<<endl;
					cout<<"Keliling Lingkaran Adalah : "<<kllLing1(r);
				}
				else{
					cout<<"Luas Lingkaran Adalah : "<<LuasLing2(r);
					cout<<endl;
					cout<<"Keliling Lingkaran Adalah : "<<kllLing2(r);
				}
				break;
			case 4:
				cout<<"Masukkan Alas   : "; cin>>a;
				cout<<"Masukkan Tinggi : "; cin>>t;
				cout<<endl<<endl;
				cout<<"Luasnya adalah  :  "<<luasSg(a,t)<<endl;
				cout<<"Hitung Keliling ? "; cin>>input;
				cout<<endl<<endl;
				if(input=="Ya" ||input=="ya"){
				cout<<"Sisi Pertama : "; cin>>a;
				cout<<"Sisi Kedua   : "; cin>>sp;
				cout<<"Sisi Ketiga  : "; cin>>sk;
				cout<<"Kelilingnya : "<<kllSg(a,sp,sk);
				cout<<"\n";}
			default:
				cout<<"Angka tidak valid \n\n";
				system("cls");
				goto pill;
				
		}cout<<endl; 
		cout<<"Hitung Lagi ? "; cin>>jaw; system("cls");
		if(jaw=="tidak" ||jaw=="Gak" ||jaw=="nggak"){
			break;
		}
		
   }while(jaw=="ya" ||jaw=="y" ||jaw=="Yes"); system("cls");
}
