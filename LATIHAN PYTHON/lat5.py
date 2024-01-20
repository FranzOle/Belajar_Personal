#Tipe data dalam python

tipe_dataInteger = 10
print(tipe_dataInteger)
print("Tipe data ini adalah : " , type(tipe_dataInteger))

tipe_dataFloat = 2.5
print(tipe_dataFloat)
print("Tipe data ini adalah : " , type(tipe_dataFloat))

tipe_dataString = "Hai"
print(tipe_dataString)
print("Tipe data ini adalah : " , type(tipe_dataString))

tipe_dataBoolean = True
tipe_dataBoolean2 = False
print(tipe_dataBoolean)
print(tipe_dataBoolean2)
print("Tipe data ini adalah : " , type(tipe_dataBoolean))

tipe_dataComplex = (5, 6)
print(tipe_dataComplex)
print("Tipe data ini adalah : " , type(tipe_dataComplex))
#Membuat bilangan kompleks
tipe_dataComplex2 = 3 + 4j
print("Bagian Real : ", tipe_dataComplex2.real)
print("Bagian Imajiner : ", tipe_dataComplex2.imag)
print("Tipe data ini adalah : " , type(tipe_dataComplex2))

#Tipe data CTypes
from ctypes import c_double, c_long, c_char
data_Cdouble = c_double(10.5)
data_Clong = c_long(10)
print("Tipe ini adalah : " , data_Cdouble)
print("Tipe data ini adalah  : " , type(data_Clong))