#include <iostream>
#include <stdio.h>
using namespace std;

int main (){
	char nama[10];
	int n=100;
	
	printf("Masukkan Nama : \n");
	gets(nama);
	
	cout<<"Masukkan nilaimu : \n";
	cin>>n;
	
	if (n >=90){
		printf("Wah sangat baik ya nilaimu! \n");
	}
	else if (n >=80){
		printf("Nilaimu baik tapi perbanyak belajar!, \n");
	}
	else if (n >=65){
		printf("Tidak Buruk Tapi, Lebih Serius ya! \n");
	}
	else if (n >=40){
		printf("Nilai yang cukup buruk banyakin belajar ya! \n");
	}
	else if (n >=0){
		printf("Nilaimu sangat buruk kamu harus mulai belajar \n");
	}
	
	
	
}
