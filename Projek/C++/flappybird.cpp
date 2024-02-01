#include<iostream>
#include<conio.h>
#include<dos.h>
#include<stdlib.h>
#include<string.h>
#include <windows.h>
#include <time.h>

#define LEBAR_LAYAR 90
#define TINGGI_LAYAR 26
#define LEBAR_WINSOW 70
#define LEBAR_MENU 20
#define UKURAN_JARAK 7
#define SELISIH_PIPE 45

using namespace std;

HANDLE konsol = GetStdHandle(STD_OUTPUT_HANDLE);
COORD PosisiKursor;

int PosisiPipe[3];
int PosisiCelah[3];
int FlagPipe[3];
char burung[2][6] = { '/', '-', '-', 'o', '\\', ' ',
                     '|', '_', '_', '_', ' ', '>' };
int PosisiBurung = 6;
int skor = 0;

void gotoxy(int x, int y)
{
    PosisiKursor.X = x;
    PosisiKursor.Y = y;
    SetConsoleCursorPosition(konsol, PosisiKursor);
}

void aturKursor(bool terlihat, DWORD ukuran)
{
    if (ukuran == 0)
        ukuran = 20;

    CONSOLE_CURSOR_INFO InfoKursor;
    InfoKursor.bVisible = terlihat;
    InfoKursor.dwSize = ukuran;
    SetConsoleCursorInfo(konsol, &InfoKursor);
}

void gambarBatas()
{

    for (int i = 0; i < LEBAR_LAYAR; i++)
    {
        gotoxy(i, 0);
        cout << "±";
        gotoxy(i, TINGGI_LAYAR);
        cout << "±";
    }

    for (int i = 0; i < TINGGI_LAYAR; i++)
    {
        gotoxy(0, i);
        cout << "±";
        gotoxy(LEBAR_LAYAR, i);
        cout << "±";
    }

    for (int i = 0; i < TINGGI_LAYAR; i++)
    {
        gotoxy(LEBAR_WINSOW, i);
        cout << "±";
    }
}

void generatePipe(int ind)
{
    PosisiCelah[ind] = 3 + rand() % 14;
}

void gambarPipe(int ind)
{
    if (FlagPipe[ind] == true)
    {
        for (int i = 0; i < PosisiCelah[ind]; i++)
        {
            gotoxy(LEBAR_WINSOW - PosisiPipe[ind], i + 1);
            cout << "***";
        }
        for (int i = PosisiCelah[ind] + UKURAN_JARAK; i < TINGGI_LAYAR - 1; i++)
        {
            gotoxy(LEBAR_WINSOW - PosisiPipe[ind], i + 1);
            cout << "***";
        }
    }
}

void hapusPipe(int ind)
{
    if (FlagPipe[ind] == true)
    {
        for (int i = 0; i < PosisiCelah[ind]; i++)
        {
            gotoxy(LEBAR_WINSOW - PosisiPipe[ind], i + 1);
            cout << "   ";
        }
        for (int i = PosisiCelah[ind] + UKURAN_JARAK; i < TINGGI_LAYAR - 1; i++)
        {
            gotoxy(LEBAR_WINSOW - PosisiPipe[ind], i + 1);
            cout << "   ";
        }
    }
}

void gambarBurung()
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            gotoxy(j + 2, i + PosisiBurung);
            cout << burung[i][j];
        }
    }
}

void hapusBurung()
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            gotoxy(j + 2, i + PosisiBurung);
            cout << " ";
        }
    }
}

int tabrakan()
{
    if (PosisiPipe[0] >= 61)
    {
        if (PosisiBurung < PosisiCelah[0] || PosisiBurung > PosisiCelah[0] + UKURAN_JARAK)
        {
            return 1;
        }
    }
    return 0;
}

void debug()
{
}

void gameover()
{
    system("cls");
    cout << endl;
    cout << "\t\t--------------------------" << endl;
    cout << "\t\t-------- Game Over -------" << endl;
    cout << "\t\t--------------------------" << endl
         << endl;
    cout << "\t\tTekan tombol apapun untuk kembali ke menu.";
    getch();
}

void updateSkor()
{
    gotoxy(LEBAR_WINSOW + 7, 5);
    cout << "Skor: " << skor << endl;
}

void instruksi()
{
    system("cls");
    cout << "Instruksi";
    cout << "\n----------------";
    cout << "\n Tekan spasi untuk membuat burung terbang";
    cout << "\n\nTekan tombol apapun untuk kembali ke menu";
    getch();
}

void mainGame()
{
    PosisiBurung = 6;
    skor = 0;
    FlagPipe[0] = 1;
    FlagPipe[1] = 0;
    PosisiPipe[0] = PosisiPipe[1] = 4;

    system("cls");
    gambarBatas();
    generatePipe(0);
    updateSkor();

    gotoxy(LEBAR_WINSOW + 5, 2);
    cout << "FLAPPY BIRD";
    gotoxy(LEBAR_WINSOW + 6, 4);
    cout << "----------";
    gotoxy(LEBAR_WINSOW + 6, 6);
    cout << "----------";
    gotoxy(LEBAR_WINSOW + 7, 12);
    cout << "Kontrol ";
    gotoxy(LEBAR_WINSOW + 7, 13);
    cout << "-------- ";
    gotoxy(LEBAR_WINSOW + 2, 14);
    cout << " Spasi = lompat";

    gotoxy(10, 5);
    cout << "Tekan tombol apapun untuk memulai";
    getch();
    gotoxy(10, 5);
    cout << "                      ";

    while (1)
    {
        if (kbhit())
        {
            char ch = getch();
            if (ch == 32)
            {
                if (PosisiBurung > 3)
                    PosisiBurung -= 3;
            }
            if (ch == 27)
            {
                break;
            }
        }

        gambarBurung();
        gambarPipe(0);
        gambarPipe(1);
        debug();
        if (tabrakan() == 1)
        {
            gameover();
            return;
        }
        Sleep(100);
        hapusBurung();
        hapusPipe(0);
        hapusPipe(1);
        PosisiBurung += 1;

        if (PosisiBurung > TINGGI_LAYAR - 2)
        {
            gameover();
            return;
        }

        if (FlagPipe[0] == 1)
            PosisiPipe[0] += 2;

        if (FlagPipe[1] == 1)
            PosisiPipe[1] += 2;

        if (PosisiPipe[0] >= 40 && PosisiPipe[0] < 42)
        {
            FlagPipe[1] = 1;
            PosisiPipe[1] = 4;
            generatePipe(1);
        }
        if (PosisiPipe[0] > 68)
        {
            skor++;
            updateSkor();
            FlagPipe[1] = 0;
            PosisiPipe[0] = PosisiPipe[1];
            PosisiCelah[0] = PosisiCelah[1];
        }
    }
}

int main()
{
    aturKursor(0, 0);
    srand((unsigned)time(NULL));

    do
    {
        system("cls");
        gotoxy(10, 5);
        cout << " -------------------------- ";
        gotoxy(10, 6);
        cout << " |      Flappy Bird       | ";
        gotoxy(10, 7);
        cout << " --------------------------";
        gotoxy(10, 9);
        cout << "1. Mulai Permainan";
        gotoxy(10, 10);
        cout << "2. Instruksi";
        gotoxy(10, 11);
        cout << "3. Keluar";
        gotoxy(10, 13);
        cout << "Pilih opsi: ";
        char opsi = getche();

        if (opsi == '1')
            mainGame();
        else if (opsi == '2')
            instruksi();
        else if (opsi == '3')
            exit(0);

    } while (1);

    return 0;
}

