#include <iostream>

using namespace std;

int main()
{
    int pembelian,harga,jumlah,total,pembayaran, kembali, nomor1,jawaban13,jawaban6,jawaban7;
    double harga1,harga2,harga3,harga4,harga5,harga6,harga7,tharga1,tharga2,tharga3,tharga4,tharga5,tharga6,tharga7;

    string jawaban1,jawaban2,jawaban3,jawaban4,jawaban5,jawaban8,jawaban9,jawaban10,jawaban12;
    char jawaban,next;
    string jawaban11;
    char sandiemail[35];

        int jumlah1=0;
        int *a =&jumlah1;
        int jumlah2=0;
        int *b =&jumlah2;
        int jumlah3=0;
        int *c= &jumlah3;
        int jumlah4=0;
        int *d =&jumlah4;
        int jumlah5=0;
        int *e =&jumlah5;
        int jumlah6=0;
        int *f =&jumlah6;
        int jumlah7 =0;
        int *g =&jumlah7;
        char alamatemail[35]={};
        char *h =&alamatemail[35];







        cout << "       Selmamat Datang Aplikasi Pemesanan Kantin SMK 2         " << endl;
        cout << "---------------------------------------------------------------" << endl << endl;
            cout << "Ketik Nama Kamu : ";
            cin >> jawaban11;
            cout << "" << endl << endl;


        cout << "Masuk Ke Akun Anda untuk memesan :\n";
        cout << "             1.Masuk\n";
        cout << "             2.Daftar\n";
        cout << "             3.Gunakan Aplikasi Tapa Daftar/Masuk\n";
        cout << "Pilih salah satu  : ";
        cin >> jawaban7;


        if (jawaban7 == 2)  {
            cout << "Anda Sebagai ?";
            cout << "    Siswa     \n";
            cout << "    Guru      \n";
            cout << "    Staf      \n";
            cin >> jawaban8;
            cout << " \n\n\n";
            cout << "Masukkan Nama depan : ";
            cin >> jawaban9;
            cout << "Masukkan Nama belakang :  ";
            cin >> jawaban10;
            cout << "Masukkan Nomor Kartu Pelajar Anda : ";
            cin >> nomor1;
            cout << "Masukkan Alamat Email Anda : ";
            cin >> *h;
            cout << "Masukkan Sandi Anda : ";
            cin >> sandiemail;
            cout << "                                                        \n";
            cout << "                                                        \n";
            cout << "                                                        \n";
            cout << "                                                        \n";
            cout << "                                                        \n";
            cout << "                                                    KAMI SEDANG MEMPROSES AKUN ANDA       \n";
            cout << "                                                        \n";
            cout << "                                                        \n";
            cout << "                                                        \n";
            cout << "                                                        \n";
            cout << "                                                        \n";
            cout << "Ketik Space Enter untuk melanjutkan!";
            cin >> next;
            cout << "\nSelamat Datang di Aplikasi Kantin Smenda " << jawaban9 <<" " << jawaban10 << endl;
            cout << "Kamu dapat memesan berbagai macam makanan & minuman yang dijual dikantin tanpa ribet\n";
            cout << "Have Joy :D <3 \n\n";
            cout << "Ingin Pesan Sekarang atau Nanti nih ?" ;
            cin >> jawaban3;
            cout << "\n\n\n";
            if (jawaban3 == "pesansekarang") {goto awal;}
            else if (jawaban3== "nanti"){goto selesai;}

        }

        else if (jawaban7==1) {
            cout << "Masukkan Alamat Email Anda : ";
            cin >> alamatemail;
            cout << "Masukkan Sandi Anda : ";
            cin >> sandiemail;
            cout << "\nSelamat Datang di Aplikasi Kantin Smenda " << alamatemail << endl;
            cout << "Kamu dapat memesan berbagai macam makanan & minuman yang dijual dikantin tanpa ribet\n";
            cout << "Have Joy :D <3 \n\n";
            cout << "Ingin Pesan Sekarang atau Nanti nih ?" ;
            cin >> jawaban3;
            cout << "\n\n\n";
            if (jawaban3 == "pesansekarang") {goto awal;}
            else if (jawaban3== "nanti"){goto selesai;}

        }

        else if (jawaban7==3) {
            cout << "Ketik Nama Depan : ";
            cin >> jawaban11;
            cout << "Kamu dari kelas apa : ";
            cin >> jawaban12;
            cout << "\nSelamat Datang di Aplikasi Kantin Smenda " << jawaban11 << endl;
            cout << "Kamu dapat memesan berbagai macam makanan & minuman yang dijual dikantin tanpa ribet\n";
            cout << "Have Joy :D <3 \n\n";
            cout << "Ingin Pesan Sekarang atau Nanti nih ?" ;
            cin >> jawaban3;
            cout << "\n\n\n";
            if (jawaban3 == "pesansekarang") {goto awal;}
            else if (jawaban3== "nanti"){goto selesai;}
        }

        awal:
        cout << "  Ketik Mulai untuk memesan, Batal untuk Kembali : " ;
        cin >> jawaban1;



        if (jawaban1 == "mulai") {
        pilihan :
        cout << "     Daftar Harga Makanan dan Minuman                Harga" << endl;
        cout << "    1. Mie Ayam Khas Solo                        Rp. 8.500,- " << endl;
        cout << "    2. Bakso Malang                              Rp. 7.500,- " << endl;
        cout << "    3. Nasi Goreng Matematika                    Rp. 10.000,- " << endl;
        cout << "    4. Soto Ayam Mbak Yuu                        Rp. 9.000,- " << endl;
        cout << "    5. Aneka Jus Buah                            Rp. 5.000,- " << endl;
        cout << "    6. Aneka Pop Ice                             Rp. 3.500,- " << endl;
        cout << "    7. Kerupuk                                   Rp. 500,-   " << endl << endl;



        cout << "\n\n                  Masukkan Makanan/Minuman yang akan anda beli (1-6)  : " << endl;
        cin >> pembelian ;


        if(pembelian == 1) {
            cout << "Mie Ayam Khas Solo, Harga Rp. 8.500,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> *a;
            harga1 = 8500;
            tharga1 = *a *harga1;
            cout << "Total harga : Rp." << tharga1;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            cout << "\n\n\n";
            if (jawaban3 == "belilagi") {goto pilihan;}
            else if (jawaban3== "checkout"){goto checkout;}
             }


         else if(pembelian == 2) {
            cout << "Bakso Malang, Harga Rp. 7.500,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> *b;
            harga2 = 7500;
            tharga2 = *b *harga2;
            cout << "Total harga : Rp." << tharga2;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            if (jawaban3 == "belilagi") {goto pilihan;}
            else if (jawaban3== "checkout"){goto checkout;}


        }
         else if(pembelian == 3) {
            cout << "Nasi Goreng Setan, Harga Rp. 10.000,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> *c;
            harga3 = 10000;
            tharga3 = *c *harga3;
            cout << "Total harga : Rp." << tharga3;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            if (jawaban3 == "belilagi") {goto pilihan;}
            else if (jawaban3== "checkout"){goto checkout;}  }

        else if(pembelian == 4) {
            cout << "Soto Ayam Mbak Yuu, Harga Rp. 9.000,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> *d;
            harga4 = 9000;
            tharga4 = *d *harga4;
            cout << "Total harga : Rp." << tharga4;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
           cin >> jawaban3;
           if (jawaban3 == "belilagi") {goto pilihan;}
            else if (jawaban3== "checkout"){goto checkout;}  }


        else if(pembelian == 5) {
            cout << "Aneka Jus Buah, Harga Rp. 5.000,- " << endl;
            cout << "Mau jus buah apa ? Tersedia (Mangga, Jeruk, Stroberi) \n";
            cin >> jawaban5;
            cout << "Masukkan Jumlah : " ;
            cin >> *e;
            harga5 = 5000;
            tharga5 = *e *harga5;
            cout << "Total harga : Rp." << tharga5;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
           if (jawaban3 == "belilagi") {goto pilihan;}
            else if (jawaban3== "checkout"){goto checkout;}  }

        else if(pembelian == 6) {
            cout << "Aneka Pop Ice, Harga Rp. 3.000,- " << endl;
            cout << "Mau Pop Ice Rasa apa ? Tersedia (Cokelat,Durian,Bubble gum, Cappucino, Taro) : ";
            cin >> jawaban4;
            cout << "\nMasukkan Jumlah : " ;
            cin >> *f;
            harga6 = 3000;
            tharga6 = *f *harga6;
            cout << "Total harga : Rp." << tharga6;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            if (jawaban3 == "belilagi") {goto pilihan;}
            else if (jawaban3== "checkout"){goto checkout;} }

        else if(pembelian == 7) {
            cout << "Kerupuk, Harga Rp. 500,- " << endl;
            cout << "Masukkan Jumlah : " ;
            cin >> *g;
            harga7 = 500;
            tharga7 = *g*harga7;
            cout << "Total harga : Rp." << tharga7;
            cout << "\nApa anda yakin memasukkan item kedalam keranjang ? " ;
            cin >> jawaban2;
            cout << "\nIngin Checkout sekarang atau ingin membeli Item lainnya ?" ;
            cin >> jawaban3;
            if (jawaban3 == "belilagi") {goto pilihan;}
            else if (jawaban3== "checkout"){goto checkout;}  }





        checkout :

        cout << "\n\n";
        cout << "Nama : " << jawaban11 << endl;
        cout << "Akun : " << alamatemail << endl;

        cout << "                 \n";
            cout << "           Chekout Keranjang Anda     " << endl;
            cout << "Item yang anda masukkan ke keranjang      Jumlah            Total Harga" << endl;
        cout << "    1. Mie Ayam Khas Solo                      " << *a << "               Rp."<< *a * 8500<< endl;
        cout << "    2. Bakso Malang                            " << *b << "               Rp."<< *b * 7500 << endl;
        cout << "    3. Nasi Goreng Matematika                  " << *c << "               Rp."<< *c * 10000 << endl;
        cout << "    4. Soto Ayam Mbak Yuu                      " << *d << "               Rp."<< *d * 9000<< endl;
        cout << "    5. Aneka Jus Buah                          " << *e << "               Rp."<< *e * 5000 << endl;
        cout << "    6. Aneka Pop Ice                           " << *f << "               Rp."<< *f * 3000 << endl;
        cout << "    7. Kerupuk                                 " << *g << "               RP."<< *g * 500  << endl;
        int alljumlah=*a * 8500+*b * 7500+*c * 10000+*d * 9000+*e * 5000+*f * 3000+*g * 500;
        cout << "                                                      Total Keseluruhan : Rp." << alljumlah;
        cout << "\n\n Pilih metode pengambilan barang : \n";
        cout << "1. Ambil ditempat\n";
        cout << "2. Delivery (pajak 2%)\n";
        cout << "pilih (1-2)" ;
        cin >> jawaban13;
        int pajak = alljumlah*2/100;
        int tpajak = alljumlah+pajak;


        if (jawaban13==2) {

            cout << "\n";
            cout << "Pengambilan barang secara delivery dikenakan pajak 2% dari total harga\n";
            cout << " Jadi total pembayaran anda setelah pajak 2% adalah Rp.";
            cout << tpajak;
            cout << "\n";
            cout << "Pilih Lokasi Kelas Untuk Mengantarkan Barang (Contoh tr28) :";
            char lokasi[5];
            cin >> lokasi;
            cout << "Terimakasih kami akan mengantarkan barang anda setelah memilih metode pembayaran\n";
            goto pembpajak;
        }
        if (jawaban13==1) {
            goto pembayaran;
            }

        pembayaran:
        cout << "\n\n Pilih metode pembayaran anda : \n";
        cout << "1. Pemabayaran tunai\n";
        cout << "2. Pembayaran M-Banking (Diskon 10%) \n";
        cout << "3. Pembayaran Kredit Kopsis Smenda (Diskon 15%)\n";
        cin >> jawaban6;
        if (jawaban6==1) {
            inputuang1 :

            cout << "\nTotal Pembayaran anda sebesar Rp." << alljumlah << ",-  Silahkan Membayar di tempat" << endl;
            cout << "Inputkan Uang Anda : Rp.";
            int uang;
            cin >> uang;
            cout << "\n";
            cout << "Total Pembayaran : Rp." << alljumlah << endl;
            cout << "Anda Membayar : Rp." << uang << endl;
            int kembalian = uang - alljumlah;
            if (uang < alljumlah ) {
                cout << "Uang Anda Kurang !\n";
                goto inputuang1;
            }
            cout << "Kembalian Anda : Rp." << kembalian << endl;
            cout << "Silahkan Ambil Kembalian anda di kasir" << endl;
            goto selesai;

        }
       else if (jawaban6==2) {
            cout << "\nTotal Pembayaran anda sebesar Rp." << alljumlah << ",- Silahkan Membayar di tempat"<< endl;
            cout << "Masukkan Nomor Rekening Anda : " ;
            char norek[10];
            cin >> norek;
            cout << "\n";
            cout << "Nomor Rekening Anda   : " << norek << endl;
            cout << "Atas Nama             : " << jawaban11 << endl;
            cout << "Dengan Total Saldo    : " << "XXXXXXXX" << endl;
            int diskon1 = alljumlah*10/100;
            int mbank = alljumlah-diskon1;
            cout << "Saldo akan dipotong untuk pembayaran sebesar Rp." << mbank << endl;
            cout << "Ketik setuju untuk melanjutkan pembayaran : " ;
            string setuju;
            cin >> setuju;
            cout << "Total Pembayaran : Rp." << mbank << endl;
            cout << "Anda Membayar : Rp." << mbank  << endl;
            goto selesai;


       }
       else {
            int diskon2 = alljumlah*15/100;
            int smendapay = alljumlah-diskon2;

            cout << "\nTotal Pembayaran anda sebesar Rp." << smendapay << endl;
            cout << "Silahkan Membayar Menggunakan Kode di SMENDAPay" << endl;
            char kodepmb[4];
            cout << "Masukkan kode pembayaran : ";
            cin >> kodepmb;
            cout << "\nSaldo akan dipotong untuk pembayaran sebesar Rp." << smendapay << endl;
            cout << "Ketik setuju untuk melanjutkan pembayaran : " ;
            string setuju;
            cin >> setuju;
            cout << "\nTotal Pembayaran : Rp." <<smendapay << endl;
            cout << "Anda Membayar : Rp." << smendapay  << endl;
            goto selesai;


       }


       pembpajak:
        cout << "\n Pilih metode pembayaran anda : \n";
        cout << "1. Pemabayaran tunai\n";
        cout << "2. Pembayaran M-Banking (Diskon 10%)\n";
        cout << "3. Pembayaran Kredit Kopsis Smenda (Diskon 15%)\n";
        cin >> jawaban6;
        if (jawaban6==1) {
            inputuang2 :
            cout << "\nTotal Pembayaran anda sebesar Rp." << tpajak << ",- Silahkan Membayar di tempat" << endl;
            cout << "Inputkan Uang Anda : Rp.";
            int uang;
            cin >> uang ;
            cout << "\nTotal Pembayaran : Rp." << tpajak << endl;
            cout << "Anda Membayar : Rp." << uang << endl;
            int kembalian = uang - tpajak;
            if (uang < tpajak ) {
                cout << "Uang Anda Kurang !\n";
                goto inputuang2;
            }
            cout << "Kembalian Anda : Rp." << kembalian << endl;
            cout << "Silahkan Ambil Kembalian anda di kasir" << endl;
            goto selesai;

        }
       else if (jawaban6==2) {
            cout << "\nTotal Pembayaran anda sebesar Rp." << tpajak << "Silahkan Membayar di tempat"<< endl;
            cout << "Masukkan Nomor Rekening Anda : " ;
            char norek[10];
            cin >> norek;
            cout << "Nomor Rekening Anda : " << norek << endl;
            cout << "Atas Nama           : " << jawaban11 << endl;
            cout << "Dengan Total Saldo  : " << "XXXXXXXX" << endl;
            int diskon1 = tpajak*10/100;
            int mbank = tpajak-diskon1;
            cout << "Saldo akan dipotong untuk pembayaran sebesar Rp." << mbank << endl;
            cout << "Ketik setuju untuk melanjutkan pembayaran : ";
            string setuju;
            cin >> setuju;
            cout << "\nTotal Pembayaran : Rp." << mbank << endl;
            cout << "Anda Membayar : Rp." << mbank << endl;
            goto selesai;


       }
       else {
            int diskon2 = tpajak*15/100;
            int smendapay = tpajak-diskon2;

            cout << "\nTotal Pembayaran anda sebesar Rp." << smendapay << endl;
            cout << "Silahkan Membayar Menggunakan Kode di SMENDAPay" << endl;
            char kodepmb[4];
            cout << "Masukkan kode pembayaran : ";
            cin >> kodepmb;
            cout << "\n";
            cout << "Saldo akan dipotong untuk pembayaran sebesar Rp." << smendapay << endl;
            cout << "Ketik setuju untuk melanjutkan pembayaran : ";
            string setuju;
            cin >> setuju;
            cout << "\nTotal Pembayaran : Rp." <<smendapay << endl;
            cout << "Anda Membayar : Rp." << smendapay  << endl;
            goto selesai;


}
        }
  else {
    cout << "                             \n\n\nTerimaksih telah mengunjugi aplikasi kantin smk2 berikan feedback dan dukungan agar kami semakin berkembang :)" << endl;
    cout << "                                                        this program was created by_nando" << endl;
  }

  selesai :
        cout << "                             \n\n\nTerimaksih telah mengunjugi aplikasi kantin smk2 berikan feedback dan dukungan agar kami semakin berkembang :)" << endl;
    cout << "                                                        this program was created by_nando" << endl;
}

