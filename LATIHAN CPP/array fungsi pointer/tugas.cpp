#include <iostream>
using namespace std;

int main(){
	int myarr[2][4][3]{{{11,12,13},{14,15,16},{17,18,19},{10,11,12}},
	{{21,22,23},{24,25,26},{27,28,29},{10,11,12}}};
	
	cout<<"Array Pertama \n";
	cout<<"------------\n";
	for(int a=0; a<2; a++){
		for(int b=0; b<4; b++){
			for(int c=0; c<3; c++){
				cout<<myarr[a][b][c]<<"  ";
				
			}
			cout << endl;
		}
		cout<<endl;
		}
	int youarr[2][4][3]{{{11,12,13},{14,15,16},{17,18,19},{10,11,12}},
	{{21,22,23},{24,25,26},{27,28,29},{10,11,12}}};

	cout<<"Array Kedua \n";
	cout<<"------------\n";
	for(int a=0; a<2; a++){
		for(int b=0; b<4; b++){
			for(int c=0; c<3; c++){
				cout<<youarr[a][b][c]<<"  ";
				
			}
			cout << endl;
		}
		cout<<endl;
		}
		cout<<endl;
		cout<<"Pertambahan Array \n";
		for(int a=0; a<2; a++){
		for(int b=0; b<4; b++){
			for(int c=0; c<3; c++){
				cout<<youarr[a][b][c]+myarr[a][b][c]<<"  ";
				
			}
			cout << endl;
		}
		cout<<endl;
		}
}
