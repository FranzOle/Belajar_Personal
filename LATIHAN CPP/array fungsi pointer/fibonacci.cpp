#include <iostream>
using namespace std;



int main () {
	cout << "Bilangan Fibbonaci" << endl;
	
	int b=1,a=0,hasil;
		for (int g=1; g<10; g++ ) {
			hasil=a+b;
			cout << a <<"+" << b << "=";
			a=b;
			b=hasil;
			
			cout<<hasil;
			cout<<endl;
		} 
	 for(int i=1;i<=5;i++)
   {
      for(int j=1;j<=5;j++)
      {
         if(i==j)
            cout<<"*";
         else
            cout<<" ";
      }
      cout<<endl;
   }
		
	
}
