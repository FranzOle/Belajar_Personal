#Perulangan dalam Python

#for
# Mencetak angka dari 1 sampai 5
for i in range(1, 6):
  print(i)

# Mencetak string "Hello" sebanyak 5 kali
for i in range(5):
  print("Hello")


#While do
# Mencetak angka dari 1 sampai 5 (menggunakan while)
i = 1
while i <= 5:
  print(i)
  i += 1

# Menanyakan nama pengguna sampai dia memasukkan nama yang valid
nama = ""
while not nama:
  nama = input("Masukkan nama Anda: ")

print("Halo, " + nama)

#Contoh penggunaan
# Mencetak angka dari 1 sampai 10, berhenti ketika mencapai angka 5
for i in range(1, 11):
  if i == 5:
    break
  print(i)

# Mencetak angka genap dari 1 sampai 10
for i in range(1, 11):
  if i % 2 == 1:
    continue
  print(i)
  
# Mencari nilai "Python" dalam string, mencetak "Ditemukan!" jika ditemukan
kata = "Hello World Python"
for i in range(len(kata)):
  if kata[i] == "P" and kata[i+1] == "y" and kata[i+2] == "t" and kata[i+3] == "h" and kata[i+4] == "o" and kata[i+5] == "n":
    print("Ditemukan!")
    break
else:
  print("Tidak ditemukan")


# Mencetak tabel perkalian 2
for i in range(1, 11):
  print(f"2 x {i} = {2 * i}")

