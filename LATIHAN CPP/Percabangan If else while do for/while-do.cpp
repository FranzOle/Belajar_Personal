#include <iostream>
using namespace std;

int main (){
	//Program while do
	//while-do saya belajar pemograman
	cout<<"Program while-do \n\n";
	int x=1;
	while(x <=5){
		cout<<x<<". "<<"Saya belajar Pemrograman"<<endl;
		x++;
	}
	//while segitiga siku-siku
	cout<<endl;
	int a=1;
	while(a<=5){
	cout<<a;
		cout<<"\n";
		a++;
	}
	cout<<endl;
	int c=1;
	while(c<=5){
		int d=c;
		while(d<5){
			cout<<" ";
			cout<<" ";
			d++;
		}
		int z=1;
		while(z<=c){
			cout<<"+";
			cout<<" ";
			z++;
		}
		cout<<endl;
		c++;
	}
	cout<<endl;
	int e=1;
	while(e<=5){
		int f=e;
		while(f<=5){
			cout<<"+";
			cout<<" ";
			f++;
		}
		cout<<endl;
		e++;
	}
	cout<<endl;
	int jk=1;
	while(jk<=5){
		int kj=1;
		while(kj<=jk){
			cout<<" ";
			cout<<" ";
			kj++;
		}
		int jj=jk;
		while (jj<=5){
			cout<<"+";
			cout<<" ";
			jj++;
		}
		cout<<endl;
		jk++;
	}
	cout<<endl;
	cout<<"Program do-while \n \n";
	//Program do while
	int i=1;
	do{
		cout<<i<<". "<<"Saya Belajar Pemograman"<<endl;
		i++;
		}
	while(i<=5);
	cout<<endl;
	
	//segitiga siku siku do-while
		int nando=1;
			do{
				int onel=nando;
				do{
					cout<<" ";
					cout<<" ";
					onel++;
				}while(onel<=5);
				int joko=1;
				do{
					cout<<"+";
					cout<<" ";
					joko++;
				}while(joko<=nando);
				cout<<endl;
				nando++;
			}
			while(nando<=5);
	int ll=1;
	do{
		int lk=1;
		do{
			cout<<"+";
			cout<<" ";
			lk++;}
			while(lk<=ll);
			cout<<endl;
			ll++;
		}
			while(ll<=5);
			cout<<endl;
			
			int lkk=1;
			do{
				int lkl=lkk;
				do{
					cout<<"+";
					cout<<" ";
					lkl++;
				}while(lkl<=5);
				cout<<endl;
				lkk++;
				
			} while (lkk<=5);
			cout<<endl;
			
			int zul=1;
			do{
				int lz=1;
				do{
					cout<<" ";
					cout<<" ";
					lz++;
				}while(lz<=zul);
				
				int lzl=zul;
				do{
					cout<<"+";
					cout<<" ";
					lzl++;
				}while(lzl<=5);
				cout<<endl;
				zul++;
			}while(zul<=5);
			
			int bar,jum;
			for(int x=0; x<=2; x++){
				cout<<"bar"; cin>>bar;
				cout<<"jum"; cin>>jum;
				
				cout<<"tambah : "<<bar+jum;
			}
			
	
	return 0;
	
}
