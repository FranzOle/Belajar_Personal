#Fungsi dan Methods

def ucapan_selamat(nama):
  """Mencetak ucapan selamat kepada seseorang."""
  print(f"Selamat pagi, {nama}!")

ucapan_selamat("Budi") # Mencetak "Selamat pagi, Budi!"

#Fungsi dengan nilai return
def luas_persegi(panjang):
  """Menghitung luas persegi."""
  return panjang * panjang

luas = luas_persegi(5)
print(f"Luas persegi: {luas}") # Mencetak "Luas persegi: 25"


def contoh_variabel():
  nama = "Ani"
  print(f"Nama di dalam fungsi: {nama}")

nama = "Budi"
contoh_variabel()
print(f"Nama di luar fungsi: {nama}") # Mencetak "Nama di luar fungsi: Budi"


#Contoh Penggunaan Fungsi
def total_nilai(daftar_nilai):
  total = 0
  for nilai in daftar_nilai:
    total += nilai
  return total

daftar_nilai = [80, 90, 75, 85]
total_nilai = total_nilai(daftar_nilai)
print(f"Total nilai: {total_nilai}")


