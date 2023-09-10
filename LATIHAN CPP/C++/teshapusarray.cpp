#include <iostream>
using namespace std;

string nama_siswa[5];

int main(){
	int nomor;
	string mapel[5]={"a","b","c","d","e"};
	cin>>nomor;

	for(int j=nomor; j<4; j++){
		mapel[j]=mapel[j+1];
		cout<<mapel[j]<<endl;
		
	}
	for(int i=0; i<4; i++){
		cout<<mapel[i];
	}
}
