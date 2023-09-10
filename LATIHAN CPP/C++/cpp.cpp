#include <iostream>

using namespace std;

int main()
{
    int pembelian,harga,jumlah,total,pembayaran, kembali;
    int harga1,harga2,harga3,harga4,harga5,harga6,harga7,tharga1,tharga2,tharga3,tharga4,tharga5,tharga6,tharga7;
    string jawaban1,jawaban2,jawaban3,jawaban4;
    char jawaban;




        cout << "       Selmamat Datang Aplikasi Pemesanan Kantin SMK 2         " << endl;
        cout << "---------------------------------------------------" << endl << endl;
        cout << "  Ketik Mulai untuk memesan, Batal untuk Kembali : " ;
        cin >> jawaban1;



        if (jawaban1 == "mulai") {

        cout << "     Daftar Harga Makanan dan Minuman                Harga" << endl;
        cout << "    1. Mie Ayam Khas Solo                        Rp. 8.750,- " << endl;
        cout << "    2. Bakso Malang                              Rp. 9.876,- " << endl;
        cout << "    3. Nasi Goreng Matematika                    Rp. 9.215,- " << endl;
        cout << "    4. Soto Ayam Mbak Yuu                        Rp. 8.723,- " << endl;
        cout << "    5. Aneka Jus Buah                            Rp. 4.870,- " << endl;
        cout << "    6. Aneka Pop Ice                             Rp. 3.870,- " << endl;
        cout << "    7. Kerupuk                                    Rp. 487,-   " << endl << endl;
        pilihan :
        cout << "\n                  Masukkan Makanan/Minuman yang akan anda beli (1-6)  : " << endl;
        cin >> pembelian ;

        if(pembelian == 1) {
            cout << "Mie Ayam Khas Solo, Harga Rp. 8.750,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> jumlah;
            harga1 = 8750;
            tharga1 = jumlah*harga1;
            cout << "Total harga :" << tharga1;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            cout << "\n\n\n";
            if (jawaban3 == "belilagi") {goto pilihan;}
            else if (jawaban3== "checkout"){goto checkout;}
             }


         else if(pembelian == 2) {
            cout << "Bakso Malang, Harga Rp. 9.876,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> jumlah;
            harga2 = 9876;
            tharga2 = jumlah*harga2;
            cout << "Total harga :" << tharga2;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            if (jawaban3=="belilagi") {goto pilihan;}


        }
         else if(pembelian == 3) {
            cout << "Nasi Goreng Setan, Harga Rp. 9.215,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> jumlah;
            harga3 = 9215;
            tharga3 = jumlah*harga3;
            cout << "Total harga :" << tharga3;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            if (jawaban3=="belilagi") {goto pilihan;}  }

        else if(pembelian == 4) {
            cout << "Soto Ayam Mbak Yuu, Harga Rp. 8.723,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> jumlah;
            harga4 = 8723;
            tharga4 = jumlah*harga4;
            cout << "Total harga :" << tharga4;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
           cin >> jawaban3;
           if (jawaban3=="belilagi") {goto pilihan;}  }


        else if(pembelian == 5) {
            cout << "Aneka Jus Buah, Harga Rp. 4.870,- " << endl;
            cout << "Mau jus buah apa ? Tersedia (Mangga, Jeruk, Stroberi) \n";
            cout << "Masukkan Jumlah : " ;
            cin >> jumlah;
            harga5 = 4870;
            tharga5 = jumlah*harga5;
            cout << "Total harga :" << tharga5;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
           cin >> jawaban3;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
           if (jawaban3=="belilagi") {goto pilihan;}  }

        else if(pembelian == 6) {
            cout << "Aneka Pop Ice, Harga Rp. 3.870,- " << endl;
            cout << "Mau Pop Ice Rasa apa ? Tersedia (Cokelat,Durian,Bubble gum, Cappucino, Taro) : ";
            cin >> jawaban4;
            cout << "\nMasukkan Jumlah : " ;
            cin >> jumlah;
            harga6 = 3870;
            tharga6 = jumlah*harga6;
            cout << "Total harga :" << tharga6;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            if (jawaban3=="belilagi") {goto pilihan;}  }

        else if(pembelian == 7) {
            cout << "Kerupuk, Harga Rp. 487,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> jumlah;
            harga7 = 487;
            tharga7 = jumlah*harga7;
            cout << "Total harga :" << tharga7;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            if (jawaban3=="belilagi") {goto pilihan;}  }




        checkout :
            cout << "Chekout Keranjang Anda : " << endl;



}

  else {
    cout << "Terimaksih telah mengunjugi aplikasi kantin smk2\n berikan feedback dan dukungan agar kami semakin berkembang :)" << endl << endl << endl;
  }
}