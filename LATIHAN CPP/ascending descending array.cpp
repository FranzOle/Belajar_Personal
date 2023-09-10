#include <iostream>
using namespace std;

int main(){
	
	//bubble sort
	int simpan;
	int n;
	cin>>n;
	int arr[n];
	
	for(int a=0; a<n; a++){
		cout<<"Masukkan array : "; cin>>arr[a];
	}
	
	for(int b=0; b<n; b++){
		for(int j=0; j<n; j++){
			if(arr[j]>arr[j+1]){
				simpan=arr[j];
				arr[j]=arr[j+1];
				arr[j+1]=simpan;
			}
		}
	}cout<<endl;
	cout<<"Data setelah diurutkan (ASCENDING) : "<<endl;
	for(int i=1; i<=n; i++){
		cout<<arr[i]<<endl;
	}

}
