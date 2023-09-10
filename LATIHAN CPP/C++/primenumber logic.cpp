#include <iostream>
using namespace std;

int main(){
	int n,x=0;
	cin>>n;
	for(int a=1; a<=n; a++){
		if(n%a==0){
			x++;
			cout<<x<<endl<<a<<endl;
		}
	
	}
	if(x==2){
			cout<<"Prime \n";
		
		}
		else{
			cout<<"Not prime \n";
		}
}
