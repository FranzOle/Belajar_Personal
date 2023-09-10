#include <iostream>
using namespace std;
int main(){
	int ab[];
	int harga[];
	int sub[];
	char jawab;
	int i=0;
	int tot=0;
	while(true){
		cin>>ab[i];
	    cin>>harga[i];
	    cin>>jawab;
	    sub[i]=ab[i]*harga[i];
		tot+=sub[i];
		i++;
		if (jawab=='n'){
			break;
		}
		
	    
	}
	cout << tot;
	
}
