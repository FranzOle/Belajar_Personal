#include <iostream>
using namespace std;


int main () {
	
	//Belajar Array menguji 2 himpunan irisan
	int arr[5];
	cout << "Masukkan Anggota Himpunan A : ";
	for (int i=0; i<5; i++) {
		cin >> arr[i];
	}
	
	int lilnusnus = 1;
	cout << "A {";
	for (int j=0; j<5; j++) {
		cout << arr[j] ;
		
		if (j<4) {
			cout << ",";
		}
		else if (j==4){
			cout << "}" << endl;
		}
		
		cout << "Hasil Perkalian" << lilnusnus;
		lilnusnus = lilnusnus*arr[j];
		cout << "*" << arr[j] << lilnusnus << endl;
	}
     cout << "Total Perkalian :" << lilnusnus;
	/*
	int arr[];
	cout << "Masukkan Anggota Himpunan B : ";
	for (int i=0; i<5; i++) {
		cin >> arr[i];
	}
	
	cout << "A {";
	for (int j=0; j<5; j++) {
		cout << arr[j] ;
		if (j<4) {
			cout << ",";
		}
		else if (j==4){
			cout << "}" << endl;
		}
	}
	
*/
}
