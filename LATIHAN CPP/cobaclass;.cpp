#include <iostream>
using namespace std;

class Biodata{
	private:
		int umur,kls[4]{10,11,12,13},kelas;
		string jurusan[17]{"Fisika","Ekonomi","Akutansi","Informatika","Teknik Mesin","Kedokteran","Teknik Dirgantara","Perkapalan","Perbankan","Desain Grafis","Pertanian",
		"Kimia","Teknik Industri","Teknik Nuklir","Psikologi","Sosiologi","Matematika"};
	    string nama,asal,jurusan2;
	public:
		void masuk(){
		 cout<<"Nama Lengkap : "; cin>>nama;
		 cout<<"Jurusan : "; cin>>jurusan2;
		 cout<<"Kelas : "; cin>>kelas;
		 cout<<"Asal : "; cin>>asal;
		}
		
		void valid(){
			
		}
		void tampilkan(){
			cout<<nama;
		}		
};

int main (){
	Biodata objek;
	objek.masuk();
	objek.tampilkan();
}
