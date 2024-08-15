#OOP Object-Oriented Programming Konstruktor

#Kelas 
class Kelas:
    #Konstruktor default
    def __init__(self):
        self.halo = "Ini Konstruktor"
        
    #method untuk menampilkan isi konstruktor 
    def outputKelas(self):
        print(self.halo)
        
objek = Kelas()
objek.outputKelas()

#Kelas Hewan
class Hewan:
    def __init__(self, nama, jenis):
        #Inisialisasi objek hewan.
        self.nama = nama
        self.jenis = jenis

    def bersuara(self):
        if self.jenis == "Kucing":
            print("Miaow!")
        elif self.jenis == "Anjing":
            print("Guk! Guk!")
        else:
            print("Suara hewan tidak diketahui.")

# Membuat objek hewan
kucing1 = Hewan("Garfield", "Kucing")
anjing1 = Hewan("Rex", "Anjing")

# Menampilkan informasi hewan
kucing1.bersuara()
anjing1.bersuara()
