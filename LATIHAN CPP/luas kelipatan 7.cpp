#include <iostream>
using namespace std;
int main (){
	float phi ;
	int r;
	cout<<"Masukkan jari jari";
	cin>>r;
	if (r %7==0) {
		phi=22/7*r*r;
	}
	else {
		phi=3.14*r*r;
	}
	cout<<"The answer is : \n"<<phi;
	return 0;
}

