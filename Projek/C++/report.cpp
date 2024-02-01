#include <iostream>
#include <vector>
#include <string>

using namespace std;

class Siswa {
private:
    string nama;
    int nik;
    float nilai;

public:
    Siswa(string nama, int nik) : nama(nama), nik(nik), nilai(0.0) {}

    string getNama() const {
        return nama;
    }

    int getNIK() const {
        return nik;
    }

    float getNilai() const {
        return nilai;
    }

    void setNilai(float nilai) {
        this->nilai = nilai;
    }
};

class Rapor {
private:
    vector<Siswa> daftarSiswa;

public:
    void tambahSiswa(const Siswa& siswa) {
        daftarSiswa.push_back(siswa);
    }

    void hapusSiswa(int nik) {
        for (auto it = daftarSiswa.begin(); it != daftarSiswa.end(); ++it) {
            if (it->getNIK() == nik) {
                daftarSiswa.erase(it);
                break;
            }
        }
    }

    void tampilkanRapor() const {
        cout << "=== Rapor SMKN 2 Buduran ===" << endl;
        for (const auto& siswa : daftarSiswa) {
            cout << "Nama: " << siswa.getNama() << "\tNIK: " << siswa.getNIK() << "\tNilai: " << siswa.getNilai() << endl;
        }
        cout << "=====================" << endl;
    }

    void inputNilai(int nik, float nilai) {
        for (auto& siswa : daftarSiswa) {
            if (siswa.getNIK() == nik) {
                siswa.setNilai(nilai);
                break;
            }
        }
    }
};

int main() {
    Rapor rapor;

    while (true) {
        cout << "Menu:" << endl;
        cout << "1. Tambah Siswa" << endl;
        cout << "2. Hapus Siswa" << endl;
        cout << "3. Tampilkan Rapor" << endl;
        cout << "4. Input Nilai" << endl;
        cout << "0. Keluar" << endl;

        int pilihan;
        cout << "Pilih menu (0-4): ";
        cin >> pilihan;

        switch (pilihan) {
            case 1: {
                string nama;
                int nik;
                cout << "Masukkan Nama: ";
                cin.ignore(); // Membersihkan buffer
                getline(cin, nama);
                cout << "Masukkan NIK: ";
                cin >> nik;
                Siswa siswa(nama, nik);
                rapor.tambahSiswa(siswa);
                cout << "Siswa berhasil ditambahkan." << endl;
                break;
            }
            case 2: {
                int nik;
                cout << "Masukkan NIK siswa yang akan dihapus: ";
                cin >> nik;
                rapor.hapusSiswa(nik);
                cout << "Siswa berhasil dihapus." << endl;
                break;
            }
            case 3:
                rapor.tampilkanRapor();
                break;
            case 4: {
                int nik;
                float nilai;
                cout << "Masukkan NIK siswa: ";
                cin >> nik;
                cout << "Masukkan nilai siswa: ";
                cin >> nilai;
                rapor.inputNilai(nik, nilai);
                cout << "Nilai siswa berhasil diinput." << endl;
                break;
            }
            case 0:
                cout << "Program berakhir. Terima kasih!" << endl;
                return 0;
            default:
                cout << "Pilihan tidak valid. Silakan pilih lagi." << endl;
        }
    }

    return 0;
}

