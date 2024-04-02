import tkinter as tk
from PIL import Image, ImageTk

# Define kategori BMI
KATEGORI_BMI = {
  "Kurus": (0, 18.5),
  "Normal": (18.5, 25),
  "Berlebihan": (25, 30),
  "Obesitas Kelas I": (30, 35),
  "Obesitas Kelas II": (35, 40),
  "Obesitas Kelas III": (40, float("inf"))
}

# Fungsi untuk menghitung BMI dan kategori
def hitung_bmi():
  berat_kg = float(entri_berat.get())
  tinggi_meter = float(entri_tinggi.get())
  bmi = round(berat_kg / (tinggi_meter ** 2), 2)
  kategori = next(k for k, v in KATEGORI_BMI.items() if v[0] <= bmi < v[1])
  label_hasil['text'] = f"BMI: {bmi} ({kategori})"
  update_diagram(bmi)

# Fungsi untuk memperbarui diagram BMI
def update_diagram(bmi):
  diagram_bmi.delete("all")
  x1, y1, x2, y2 = 50, 50, 250, 250
  sudut_awal, sudut_akhir = 0, 360 * (bmi / 40)
  diagram_bmi.create_arc((x1, y1, x2, y2), start=sudut_awal, extent=sudut_akhir, fill="green")
  diagram_bmi.create_text((x1 + (x2 - x1) / 2, y1 + (y2 - y1) / 2), text=f"{bmi}")

akar = tk.Tk()
akar.title("Kalkulator BMI")

# Buat frame untuk elemen GUI
frame_utama = tk.Frame(akar)
frame_utama.pack(padx=10, pady=10)

# Label dan entri untuk berat badan
label_berat = tk.Label(frame_utama, text="Berat (kg): ")
label_berat.grid(column=0, row=0, sticky="E")

entri_berat = tk.Entry(frame_utama, width=10)
entri_berat.grid(column=1, row=0)

# Label dan entri untuk tinggi badan
label_tinggi = tk.Label(frame_utama, text="Tinggi (meter): ")
label_tinggi.grid(column=0, row=1, sticky="E")

entri_tinggi = tk.Entry(frame_utama, width=10)
entri_tinggi.grid(column=1, row=1)

# Tombol untuk menghitung
tombol_hitung = tk.Button(frame_utama, text="Hitung", command=hitung_bmi)
tombol_hitung.grid(column=0, row=2, columnspan=2)

# Label untuk hasil BMI
label_hasil = tk.Label(frame_utama, text="BMI: ")
label_hasil.grid(column=0, row=3, sticky="E")

# Canvas untuk diagram BMI
diagram_bmi = tk.Canvas(frame_utama, width=200, height=200)
diagram_bmi.grid(column=1, row=3)

# Memuat gambar diagram
diagram_bg = ImageTk.PhotoImage(Image.open("diagram_bmi.jpg"))
diagram_bmi.create_image(100, 100, image=diagram_bg)

# Jalankan GUI
akar.mainloop()
