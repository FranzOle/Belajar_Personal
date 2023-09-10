#include <iostream>
#include <ctime>
#include <stdlib.h>
#include <string>

using namespace std;


//===================================
// enums simply associate integer constants (like 3 or 22) with an identifier (or enumerators if you like)
// Here we see that 10 is explicitly associated with ROCK, by default 11 will be associated with PAPER and 
// 30 is explicitly associated with SCISSORS.  
//
// If you plan to create a variable to hold one of these identifiers/enumerators then you must give the 
// enumeration a name (here its weapon)
//===================================
/*enum weapon{
      ROCK,   //identifier ROCK associated with 10
      PAPER, 
      SCISSORS
};
const int MAXNUMGames =5;

string show(weapon h){
    if (h == ROCK) {
	return "ROCK";}
    if (h == SCISSORS) return "SCISSORS";
    if (h == PAPER) return "PAPER";
}

string displayWinner(weapon h, weapon c){
        if(h == ROCK && c == SCISSORS ) return "puny human wins ... ROCK smashes SCISSORS!";
        if(h == ROCK && c == PAPER ) return "PAPER covers rock! Superior computer wins";
        if(h == SCISSORS && c == PAPER) return "puny human wins .... SCISSORS cuts PAPER!";
        if(h == SCISSORS && c == ROCK)return "ROCK smashes scissors! Superior computer wins";
        if(h == PAPER && c == ROCK) return "puny human wins .... PAPER covers ROCK!";
        if(h == PAPER && c == SCISSORS)return "SCISSORS cuts paper! Superior computer wins";
        if( h == c) return " ... DRAW!! ....";
  }*/
    


int main()
{
  /*int games_played =0;
  srand(time(NULL));//seeding random num generator
  
   int human_choice;
   weapon computer_weapon;
   weapon human_weapon;

   while(games_played < MAXNUMGames){
        
        cout <<  "What do you choose [ROCK is default]? ROCK (1), PAPER (2) or SCISSORS (3)  " ;
        cin >> human_choice;
        if(human_choice == 1) human_weapon = ROCK;
        else if(human_choice == 2) human_weapon = PAPER;
        else if(human_choice == 3) human_weapon = SCISSORS;
        else human_weapon = ROCK;

        int x = rand()%3;         
        if(x == 0) computer_weapon = ROCK;
        if(x == 1) computer_weapon = PAPER;
        if(x == 2) computer_weapon = SCISSORS;
        cout << "computer chooses " << show(computer_weapon) << endl;
        cout << displayWinner(human_we
    string lagi;
    do{
	cout<<"Masukkan Panjang Password : ";
	int n;
	cin>>n;
    const char w[]="abcdefghijklmnopqrstuvwxyz123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()|\/><,.";
    int p=sizeof(w);
    srand(time(NULL));
    for(int x=1; x<=n; x++){
    	cout<<w[rand()%p];
    	
	}cout<<endl;
	cout<<"Lagi ? : ";
	cin>>lagi;
	}while(lagi=="iya");*/
	srand(time(0));
	int n;
	n=rand()%3;
	switch(n)	{
		case 0:
			n=20;
		break;
		case 1:
		    n=25;
		break;
		case 2:
		n=30;
		break;
	}
	cout<<n;
	
	
 }

