#include <iostream>
#include <windows.h> 
#define batas_atas 2 
#define batas_bawah 23 
#define batas_samping 2 
#define batas_samping_k 78 

using namespace std;

int iX(5), iY(5), x1 (4), y1 (4), xHapus(3), yHapus(3), veloX(1), veloY(0)
   ,ekorsX[200], ekorsY[200], nEkor = 5, start = 0, makX, makY;

void gotoxy(int x, int y) 
{
 COORD pos = {x, y};
 SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), pos);
}

void naik() 
{
  veloY = -1; 
  veloX = 0; 
}

void turun()
{
  veloY = 1; 
  veloX = 0; 
}

void samping()
{
  veloX = -1; 
  veloY = 0; 
}

void samping_k()
{
  veloX = 1; 
  veloY = 0; 
}

void hapus()
{
 gotoxy(xHapus, yHapus); 
 cout << " ";
}

void ekor()
{
 for(int j = 0; j <= 2; j++)
 {
  gotoxy(ekorsX[j], ekorsY[j]);
  cout << "+";
 }
}

void tampil()
{
 gotoxy(iX, iY); 
 cout << char(2); \
 gotoxy(makX, makY);
 cout << "*"; 
}

void ganti_posisi() 
{
 xHapus = ekorsX[nEkor - 1];
 yHapus = ekorsY[nEkor - 1];
 for(int j = nEkor - 1; j >= 1; j--)
 {
  ekorsX[j] = ekorsX[j-1];
  ekorsY[j] = ekorsY[j-1];
 }
  ekorsX[0] = iX;
  ekorsY[0] = iY;
}

void velo() 
{
 ganti_posisi();
 hapus();
 iX += veloX;
 iY += veloY;
 tampil();
 ekor();
}

/*void trace()
{
 for(int j = 0; j <= nEkor -1; j++)
 {
  cout << "x" << j << " y"<< j<< " = " << ekorsX[j] << "," << ekorsY[j];
  cout << " // " << iX << "," << iY << endl;
 }
 system("pause");
 system("cls");
}*/

bool isDestroy()
{
 if(iX == batas_samping_k) { iX = 3; gotoxy(78, iY); cout << " "; }
 if(iX == batas_samping)  { iX = 77; gotoxy(2, iY); cout << " "; }
 if(iY == batas_atas) { iY = 22; gotoxy(iX, 2); cout << " "; }
 if(iY == batas_bawah) { iY = 3; gotoxy(iX, 23); cout << " "; }
 for(int j = 0; j <= nEkor - 1; j++)
  if(ekorsX[j] == iX && ekorsY[j] == iY) return true;
 return false;
}


char getkey()
{
 for(int i = 8; i <= 222; i++)
 {
  if(GetAsyncKeyState(i) == -32767)
  {
   switch(i)
   {
    case 38 : if(veloY != 1)naik();
              break;
    case 40 : if(veloY != -1)turun();
              break; 
    case 37 : if(veloX != 1)samping();
              break; 
    case 39 : if(veloX != -1)samping_k();
              break; 
   }
  }
 }
}

void random_makanan()
{
 makX = rand()%(batas_samping_k - 1);
 if(makX < 4) makX += 3 + (4-makX); 
 makY = rand()%(batas_bawah - 1);
 if(makY < 4) makY += 3 + (4-makY);
 gotoxy(makX, makY);
 cout << "*";
}

bool isEaten()
{
 if(iX == makX && iY == makY) return true; else return false;
}

void cBorder()
{
 for(int i = 1; i <= 78; i++)
 {
  for(int j = 1; j <= 24; j += 23)
  {
   if(j > 1 || i >= 32)
   {
    gotoxy(i, j);cout << char(219);
   }
  }
 }
 for(int i = 1; i <= 24; i++)
 {
  for(int k = 1; k <= 80; k += 78)
  {
   gotoxy(k, i); cout << char(219);
  }
 }
}

void skor()
{
 gotoxy(3,1); cout << "Skor : ";
 gotoxy(18,1); cout << "Panjang : ";
}

void tulis_skor()
{
 gotoxy(11,1); cout << (nEkor - 5) * 10;
 gotoxy(28,1); cout << nEkor;
}
void inisialisasi()
{
 cBorder(); 
 random_makanan(); 
 skor(); 
 tulis_skor(); 
}

int main() 
{
 system("cls"); 
 inisialisasi();
 while(!(isDestroy())) 
  {
   velo(); 
   getkey(); 
   if(isEaten())
   {
    nEkor += 1; 
    random_makanan(); 
    tulis_skor();
   }
   Sleep(40 - (nEkor / 10)); 
  }
 system("cls"); 
 gotoxy(32,12); cout << "Skor : " << (nEkor - 5) * 10; 
 gotoxy(25,13);
 system("pause"); 
}
