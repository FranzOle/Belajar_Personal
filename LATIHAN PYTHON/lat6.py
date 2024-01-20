#Casting tipe data

tipe_dataInteger = 2024
print("Belajar python di tahun : " + str(tipe_dataInteger))

tipe_dataFloat = 2.5
print("Menjadi integer " , int(tipe_dataFloat))

x = 1
y = 1
print(x + y)
print("1 + 1 adalah : " , str(x) + str(y))

tipe_dataBool = False #True
konversi = int(tipe_dataBool)
konversi2 = float(tipe_dataBool)
print(konversi , konversi2)

tipe_dataString = "True"
konversi = bool(tipe_dataString)
print(konversi , type(konversi))

tipe_dataStringAngka = "2";
# Contoh eror tidak bisa dikonversi ke-angka : tipe_dataString = "Halo"
print(int(tipe_dataStringAngka) ** 2) #eksponen