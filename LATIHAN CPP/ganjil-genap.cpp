#include <iostream>
using namespace std;
int main (){
	int n=0;
	while(n<10){
		int e=1;
		while(e<=n){
			cout<<e;
			e++;
		}
		
		n++;
		cout<<n<<endl;
	}
	
	return 0;
}
