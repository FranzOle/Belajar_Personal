#include <iostream>
using namespace std;
int main() {
	
	cout<<"UH ARRAY 3D STRING"<<endl;
	
	string huruf[2][4][2];
	
	huruf[0][0][0]='ado';
	huruf[0][0][1]='ggg';
	huruf[0][0][2]='aes';
	huruf[0][1][0]='awe';
	huruf[0][1][1]='www';
    huruf[0][1][2]='ase';
	huruf[0][2][0]='wer';
	huruf[0][2][1]='iou';
	huruf[0][2][2]='iod';
	huruf[1][0][0]='wqf';
	huruf[1][0][1]='wth';
	huruf[1][0][2]='ebj';
	huruf[1][1][0]='iig';
	huruf[1][1][1]='gdy';
	huruf[1][1][2]='fdf';
	huruf[1][2][0]='wed';
   	huruf[1][2][1]='yny';
	huruf[1][2][2]='aqs';
	
	 
	   for(int a=0; a<2; a++) {
	   	  for(int b=0; b<4; b++){
	   	  	 for(int c=0; c<2; b++){
	   	  	 	    cout<<huruf[a][b][c]<<" ";
				  }cout<<endl;
			 }
			 
	   }	
}
