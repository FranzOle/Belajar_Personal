#include <iostream>
using namespace std;

int main(){
	int myarr[5]={1,2,3,4,5};
	int search,num,add;
	cin>>num;
	for(int a=0; a<num; a++){
		cin>>myarr[a++];
	}
	for(int i=0; i<5+num; i++){
		cout<<myarr[i];
	}
}
