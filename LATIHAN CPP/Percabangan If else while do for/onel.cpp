#include <iostream>
using namespace std;
int main(){

for (int a=5; a>=1; a--) {
	for (int b=1; b<=a; b++) 
	{ cout << b;
	}
	cout << endl;
}


cout << endl; 
for (int c=1; c<=5; c++) {
	for (int d=c; d<c; d++){
		cout<<" ";
	}
	for (int e=5; e<=c; e++) {
		cout <<"+";
	}
	cout << endl;
}

}

