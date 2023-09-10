#include <iostream>
using namespace std;

int main(){
	char arrS[5]={'a','b','c','d','e'};
	char YouArr;
	cin >> YouArr;
	for(int i=0; i<5; i++){
		if(YouArr==arrS[i]){
			cout << "Data ditemukan \n";
			break;
		}
	}
}
