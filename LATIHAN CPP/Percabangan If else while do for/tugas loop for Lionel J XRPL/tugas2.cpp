#include <iostream>
using namespace std;

int main(){
	//segitiga siku siku
	for(int x=1; x<=5; x++){
		for(int y=1; y<=x; y++){
			cout<<"*";
			cout<<" ";
		}
		cout<<endl;
		
	}
	cout<<endl;
	//segitiga siku siku dari kiri
	for(int x1=5; x1>=1; x1--){
		for(int y1=1; y1<=5; y1++){
			if(y1>=x1){ 
				cout<<"*";
				}
				else{
					cout<<" ";
				}
				cout << " ";
			}
			cout<<endl;
		}
	}

