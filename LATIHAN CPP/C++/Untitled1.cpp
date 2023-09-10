#include <iostream>
#include <string>
using namespace std;

class Biodata{
	public:
		string nama;
	  Biodata (string nama1) {
	  	Biodata::nama=nama1;
	  }
	  void tampil() {
	  	cout << nama;
	  }
};

int main () {
	string nama;
	cin >> nama;
	Biodata myobj(nama);
	myobj.tampil();
	
	
}
