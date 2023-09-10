#include <iostream>
using namespace std;
 int main (){
  int x,kelPersegi,luasPersegi,kelPPanjang,luasPPanjang,s,p,l;
  char jawaban;
  pilihan:
  cout<<"selamat datang pada program penghitung luas dan keliling"<<endl;
  cout<<"pilihan perhitungan"<<endl;
  cout<<"1.Keliling Persegi"<<endl;
  cout<<"2.Luas Persegi"<<endl;
  cout<<"3.Keliling Persegi Panjang"<<endl;
  cout<<"4.Luas Persegi Panjang"<<endl;
  cout<<"Masukkan Pilihanmu : ";cin>>x;
  if (x==1 ||x==2)
  {cout<<"masukkan sisi persegi";cin>>s;
  if (x==1)
  {kelPersegi=s*4;
  cout<<"keliling persegi adalah : "<<kelPersegi<<endl;
  cout<<"Maukah anda menghitung lagi ?";cin>>jawaban;
  
  } 
   }
	 
}
