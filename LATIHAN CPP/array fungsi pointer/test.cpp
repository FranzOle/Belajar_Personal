#include <iostream>
using namespace std;

int main () {
	char myarr[5][2]= {{'a'},{'b'},{'c'},{'e'},{'d'}};
		int a=1;
		int c=0;
		cout<<"Jawaban Anda : ";
		for (int b=0; b<5; b++) {
			cin>>myarr[b][1];
			
			if (myarr[b][1]==myarr[b][0]) {
				cout << "Benar" << endl;
			}
			else {
				cout << "Salah" << endl;
			}
			
		}
		
	
}
