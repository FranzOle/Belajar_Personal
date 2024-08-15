#OOP Object-Oriented Programming Atribut dalam class

#Kelas Siswa
class Siswa:
    nama =""
    umur= 0
    kelas = 0
    #ini adalah atribut dalam class siswa
    
    def HalloSiswa(self):
        print("Hello Student") #ini adalah fungsi
        
#Jika kita ingin mengakses atribut kita perlu buat objek
siswa = Siswa()
siswa.nama = "Johan"
siswa.umur = 16
siswa.kelas = 10

print(siswa.nama)
print("Umur", siswa.nama, "adalah:", siswa.umur)
print("Kelas", siswa.nama, "adalah kelas", siswa.kelas)

#Kelas Hewan
class Hewan:
    nama = ""
    jenis = ""
    suara = ""

# Membuat objek hewan
kucing1 = Hewan()
anjing1 = Hewan()

# Membuat nilai atribut
kucing1.nama = "Garfield"
kucing1.jenis = "Kucing"
kucing1.suara = "Miaow!"

anjing1.nama = "Rex"
anjing1.jenis = "Anjing"
anjing1.suara = "Guk! Guk!"

# Menampilkan hewan
print(f"Nama Kucing: {kucing1.nama}")
print(f"Jenis Kucing: {kucing1.jenis}")
print(f"Suara Kucing: {kucing1.suara}")

print(f"Nama Anjing: {anjing1.nama}")
print(f"Jenis Anjing: {anjing1.jenis}")
print(f"Suara Anjing: {anjing1.suara}")


    