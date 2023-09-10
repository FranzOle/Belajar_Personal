#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
    using namespace std;
    int main (){
        cout<<"================================================= \n";
        cout<<"PROGRAM MENGHITUNG LUAS DAN KELILING BANGUN DATAR \n";
        cout<<"================================================= \n";
        getch();
        system("cls");
        int jawaban;
        string nama;
        cout<<"Masukkan alamat email \n";
        cin>>nama;
        system("cls");
        cout<<"\n";
        pilihan:
        cout<<"Mana bangun datar yang ingin kamu hitung \n";
        pilihan2:
        cout<<"1.Persegi \n";
        cout<<"2.Persegi Panjang \n";
        cout<<"3.Segitiga \n";
        cout<<"4.Lingkaran \n";
        cin>>jawaban;
        system("cls");
        cout<<endl;
        
        if(jawaban==1 ||jawaban==2){
            if(jawaban==1){
                x:
            cout<<"Menghitung luas atau keliling? \n";
            string pilihan;
            cin>>pilihan;
             if(pilihan=="Luas" ||pilihan=="luas"){
                double s,lp;
                cout<<"Masukkan Sisi : \n"; cin>>s;
                lp=s*s;
                cout<<"Luas Persegi adalah : "<<lp<<endl;
                getche();
                system ("cls");
             }
             else if(pilihan=="Keliling" ||"keliling"){
                 double s2;
                 cout<<"Masukkan Sisi : \n"; cin>>s2;
                 cout<<"Keliling Persegi Adalah : "<<s2*4;
                 getche();
                system ("cls");
             }
             else{
                 cout<<"Karakter tidak mendukung maaf :) \n";
                 goto x;
             }
             string ya;
             x1:
             cout<<"Mau Menghitung Lagi ? : \n"; cin>>ya;
             system("cls");
              if(ya=="ya" ||ya=="y"){
                  goto pilihan;
              }
              else if(ya=="tidak" ||ya=="gak"){
                  cout<<"Terimakasih telah menggunakan program ini :) \n";
                  for(int love=1; love<=10; love++){
                      cout<<"Makasih *_* \n";
                  }
              }
              else{
                  cout<<"Karakter tidak valid \n";
                  goto x1;
              }
            }
            else if(jawaban==2){
                y:
                string pilihan1;
                cout<<"Hitung Luas atau Keliling ? ";
                cin>>pilihan1;
                if(pilihan1=="Luas" ||pilihan1=="luas"){
                    double p,l;
                    cout<<"Masukkan panjang : "; cin>>p;
                    cout<<"Masukkan lebar   : ";cin>>l;
                    cout<<"Luas persegi pajang adalah "  <<p*l<<endl;
                }
                else if(pilihan1=="Keliling" ||"keliling"){
                    double pkl,lkl,kll;
                    cout<<"Masukkan panjang : "; cin>>pkl;
                    cout<<"Masukkan lebar   : ";cin>>lkl;
                    kll=2*(pkl+lkl);
                    cout<<"Keliling Persegi Panjang Adalah : "<<kll<<endl;
                }
                else {
                    cout<<"Karakter tidak valid maaf :/ \n";
                    goto y;
                }
                yaa:
                string ya1;
                cout<<" Mau Menghitung Lagi : ";
                cin>>ya1;
                if(ya1=="ya" ||ya1=="y"){
                    goto pilihan;
                }
                else if(ya1=="tidak" ||ya1=="gak"){
                    cout<<" Terimakasih :] \n";
                    for(int n=1; n<=10; n++){
                        for(int mq=1; mq<=n; mq++){
                        cout<<"Kamu Hebat ";
                    }
                    cout<<endl;
                    }
                }
                else{
                    cout<<"Karakter Tidak Valid";
                    goto yaa;
                }
            }
        
        }
        else if(jawaban==3 ||jawaban==4){
            if(jawaban==3){
                yy1:
                string pil;
                cout<<"Mau Menghitung Luas atau Keliling \n";
                cin>>pil;
                if(pil=="Luas" ||pil=="luas"){
                    double a,t,lsg;
                    cout<<"Masukkan alas segitiga : "; cin>>a;
                    cout<<"Masukkan Tinggi Segitiga :  "; cin>>t;
                    lsg=(a*t)/2;
                    cout<<"Luas Segitiga adalah : "<<lsg<<endl;
                }
            else if(pil=="Keliling" ||pil=="keliling"){
                double a1,t1,s1;
                cout<<"Masukkan ketiga sisi segitiga Yang Pertama "; cin>>a1,t1,s1;
                cout<<"Keliling Segitiga adalah : "<<a1+t1+s1; cout<<endl;
        
            }
            else{
                cout<<"Karakter tidak VALID maaf \n";
                goto yy1;
            }
            yoi:
                string ya2;
                cout<<" Mau Menghitung Lagi : ";
                cin>>ya2;
                if(ya2=="ya" ||ya2=="y"){
                    goto pilihan;
                }
                else if(ya2=="tidak" ||ya2=="gak"){
                    cout<<"Waw makasih \n";
                    
                }
                else{
                    cout<<"Character tidak valid \n";
                    goto yoi;
                }
            }
            else if(jawaban==4){
                string pilx;
                pilY:
                cout<<"Mau Menghitung luas atau keliling ?"; cin>>pilx;
                int r;
                const double phi=3.14;
                if(pilx=="Luas" ||pilx=="luas"){
                    cout<<"Masukkan jari-jari : "; cin>>r;
                    if(r%7==0){
                        cout<<"maka luasnya adalah : "<<(22*r*r)/7<<endl;
                    }
                    else {
                        double luaslk;
                        luaslk=phi*r*r;
                        cout<<"maka luasnya adalah : "<<luaslk<<endl;
                    }
                }
                else if(pilx=="Keliling" ||pilx=="keliling"){
                    cout<<"Masukkan Jari-Jari : ";cin>>r;
                    if(r%7==0){
                    	cout<<"Keliling lingkaran adalah : "<<(2*22*r*r)/7<<endl;
					}
					else{
						cout<<"Keliling lingkaran adalah : "<<2*phi*r<<endl;
					}
                }
                
                else{
                	cout<<"character tidak valid :) \n";
                	goto  pilY;
				}
				string pilh;
				jedg:
					cout<<"Apakah mau menghitung lagi ? ";cin>>pilh;
					if(pilh=="Ya" ||pilh=="ya"){
						goto pilihan;
					}
					else if(pilh=="tidak" ||pilh=="gak"){
						cout<<"Makasih telah menggunakan program ini :) \n";
					}
					else{
						cout<<"Character tidak valid :/ \n";
						goto jedg;
					}
            }
        }
        else {
            cout<<"Tolong inputkan angka 1-4 saja :) \n";
            goto pilihan2;
        }
        return 0;
    }
    
