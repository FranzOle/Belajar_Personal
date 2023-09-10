#include <iostream>
using namespace std;

int main(){
int n,t;
cin>>n;
bool prime=true;
if(n==0 ||n==1){
	cout<<"Angka Prima";
}
for(int i=2; i<=n/2; i++){
	if(n%1==0){
		prime=false;
		break;
	}
}
if(prime){
	cout<<"Prima";
}
}

