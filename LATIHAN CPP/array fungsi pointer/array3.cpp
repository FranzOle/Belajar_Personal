#include <iostream>
using namespace std;

int main() {

	int angkad[5];
	for (int j=0; j<5; j++) {
		cout << "Inputkan Elemen Array ke " << j << ": ";
		cin >> angkad[j];
		
	}
	cout << endl;
	for (int x=0; x<5; x++) {
		cout << "Angka ke : " << x+1 << " adalah " << angkad[x] << endl;
		
	} 
	
}
	
	
