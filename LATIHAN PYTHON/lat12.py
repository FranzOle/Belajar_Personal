inputUser = float(input("masukan angka yang bernilai\nkurang dari 3 \natau \nlebih besar dari 10\n:"))

# Memeriksa angka kurang dari 3
isKurangDari = (inputUser < 3)
print("Kurang dari 3 =", isKurangDari)

# Memeriksa angka lebih dari 10
isLebihDari = (inputUser > 10)
print("Lebih dari 10 =", isLebihDari)


isCorrect = isKurangDari or isLebihDari
print("angka yang anda masukan: ", isCorrect)

# kasus irisan
print("\n",10*"=","\n")
inputUser = float(input("masukan angka yang bernilai lebih dari 3 dan kurang dari 10\n:"))


# lebih dari 3
isLebihDari = inputUser > 3
print("Lebih dari 3 = " , isLebihDari)

# kurang dari 10
isKurangDari = inputUser < 10
print("Kurang dari 10 = " , isKurangDari)

isCorrect = isKurangDari and isLebihDari
print("angka yang anda masukan: " , isCorrect)