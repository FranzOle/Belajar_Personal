# if dan else

"""if ekspresi:
        statements """

# Nilai true akan dikerjakan didalam if

if True:
    print("True Woilah") 

# contoh 2 
if 10 > 5:
    print("10 lebih besar dari 5")

print("Program ended")

# contoh 3
a = 2
b = 3
if a == b:
    # Kode di dalam blok ini tidak akan dieksekusi karena nilai a tidak sama dengan b
    print("Nilai a sama dengan b")
else:
    # Kode di dalam blok else akan dieksekusi karena kondisi di atas tidak terpenuhi
    print("Nilai a tidak sama dengan b")

# contoh 4 dengan user input
nilai = int(input("Masukkan data : "))
if nilai >= 90:
    print("Nilai Anda A")
elif nilai >= 80:
    print("Nilai Anda B")
elif nilai >= 70:
    print("Nilai Anda C")
elif nilai >= 60:
    print("Nilai Anda D")
else:
    print("Nilai Anda E")

# contoh: Pengecekan validitas nilai siswa
nilai_siswa = 105

if nilai_siswa < 0 or nilai_siswa > 100:
    print("Nilai siswa tidak valid")
else:
    print("Nilai siswa valid")

# contoh

n = int(input("Masukkan nilai integer: "))
if n % 2 == 0:
    print("Bilangan Genap")
else:
    print("Bilangan ganjil")