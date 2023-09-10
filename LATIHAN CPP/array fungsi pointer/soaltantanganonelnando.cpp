#include <iostream>
using namespace std;

int main() {
char jawaban[5][2]{{'c'},{'b'},{'c'},{'a'},{'a'}};
float score=0;
float salah=0;
for(int a=0; a<5; a++) {
     switch (a) {
         case 0:
         cout << "1.Presiden Indonesia adalah?\n a.George VI\n b.Ahok\n c.Jokowi\n\n ";
         break;
         case 1:
         cout << "2.Salah satu sekutu Kerajaan Britania Raya Saat Perang Dunia 1 adalah..\n a.Kekaisaran Jerman\n b.Republik Prancis\n c.Kesultanan Ottoman\n\n ";
         break;
         case 2 :
         cout << "3.Kapan dimulainya Perang Dunia 2 ?\n a.1959\n b.1938\n c.1939\n\n";
         break;
         case 3:
         cout<<"4.Dimana letak Indonesia ?\n a.Asia Tenggara\n b.Eropa\n c.Asia Tengah\n\n";
         break;
         default:
         cout<<"5.Presiden Indonesia setelah Ir.Soekarno Adalah..\n a.Soeharto\n b.Soepomo\n c.SBY\n\n";
         
     }
    cout<<"Jawaban Anda : "; cin >> jawaban[a][1]; cout<<endl;
     if (jawaban[a][1]==jawaban[a][0]) {
         score=score+1;
         
         
     }
     else{
         salah=salah+1;
     }
    
    }
    cout<<endl<<endl;
    cout<<"Jawaban Betul : "<<score<<endl;
    cout<<"Jawaban Salah : "<<salah<<endl;
    float totscore= score*20;
    cout<<"Nilai Anda Adalah : "<<totscore;
    

    return 0;
}
