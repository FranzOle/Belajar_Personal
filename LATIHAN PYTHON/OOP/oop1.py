#OOP Object-Oriented Programming Objek dan class

class Hello:
    def HelloWorld(self):
        print("Ini Kelas Hello")
        
    def JoniWorld(self):
        print("Ini kelas Joni")
        
    def Segitiga(self, rows):
        segitiga = ""
        for i in range(1, rows + 1):
            segitiga += "* " * i + "\n"
        return segitiga
    
    def Perkalian(self, a, b):
        return a * b
        
object = Hello()
object.HelloWorld() #Memanggil fungsi melalui objek yang dibuat 
object.JoniWorld() #Memanggil fungsi berbeda
print(object.Segitiga(5)) #Memanggil fungsi dengan nilai return
print(object.Perkalian(2, 2))