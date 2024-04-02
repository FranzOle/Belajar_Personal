#List dalam Python

daftar_nama = ["Nando", "Reno", "Firaas"]
angka_acak = [10, 23, 4, 56, 1] #Index list dimulai dari 0

print(daftar_nama[1]) # Mencetak "Reno"
print(angka_acak[3]) # Mencetak 56
print(daftar_nama) #Mencetak semua isi variabel

#Menambahkan elemen
daftar_nama.append("Lionel") # Menambahkan "Lionel" ke akhir list
angka_acak.insert(2, 15) # Menambahkan 15 pada indeks ke-2
print(daftar_nama, "\n", angka_acak)

#Menghapus Elemen
del daftar_nama[2] # Menghapus "Firaas" dari list
angka_acak.pop(1) # Menghapus elemen pada indeks ke-1
print(daftar_nama, "\n", angka_acak)

#Sorting Elemen
daftar_nama.sort() # Mengurutkan nama secara alfabetis
angka_acak.sort(reverse=True) # Mengurutkan angka secara descending
print(daftar_nama, "\n", angka_acak)

#Method dan Fungsi pada list
panjang_list = len(daftar_nama)
print(f"Panjang list: {panjang_list}")

nando = daftar_nama.count("Nando")
print(f"Jumlah Budi dalam list: {nando}")

daftar_nama.reverse()
print(daftar_nama)

list_baru = daftar_nama.copy()
print(list_baru)

#List Menggunakan perulangan
daftar_nama = ["Budi", "Ani", "Citra", "Doni"]

for nama in daftar_nama:
  print(f"Halo, {nama}!")


daftar_angka = [1, 2, 3, 4, 5]
i = 0
while i < len(daftar_angka):
  print(f"Angka ke-{i+1}: {daftar_angka[i]}")
  i += 1
  
daftar_nilai = [80, 90, 75, 85]
total_nilai = 0

for nilai in daftar_nilai:
  total_nilai += nilai

print(f"Total nilai: {total_nilai}")


daftar_angka = [10, 23, 4, 56, 1]
nilai_maks = daftar_angka[0]

for angka in daftar_angka:
  if angka > nilai_maks:
    nilai_maks = angka

print(f"Nilai maksimum: {nilai_maks}")




