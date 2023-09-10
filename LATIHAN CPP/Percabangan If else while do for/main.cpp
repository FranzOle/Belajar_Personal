#include <iostream>

using namespace std;

int main()
{
 cout << "\nSegitiga siku siku dengan sudut kiri bawah" << endl << endl;
 for (int a=1; a<=5; a++) {
    for (int b=1; b<=a; b++) {
        cout << " +";
    }
    cout << endl;
 }

 cout << endl;
 cout << "Segitiga siku-siku dengan sudut kanan bawah" << endl << endl;
 for (int b=5; b>=1; b-- ) {
    for (int c=1; c<=5; c++) {
    if (c<b) { cout << " "; }
    else { cout << "+"; }
    cout << " ";
    }
    cout << endl;
 }
}
