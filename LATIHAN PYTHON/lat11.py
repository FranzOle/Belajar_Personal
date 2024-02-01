#Operasi logika

print("Operasi Not")
a = False
c = not a
print("Value 'a' adalah : " , a)
print("Value 'c' adalah : " , c)
print("\n")

print("Operasi or")
a = True
b = False
c = a or b
print("Nilai c = " , c) #menghasilkan nilai true jika ada true
a = True
b = True
print("True dan True akan menjadi : " , a or b)
a = False
b = False
c = a or b
print("False dan false adalah : ",c)

# jika dua buah nilai true, maka hasil truea = False
b = False
c = a and b
print(a,'AND',b,'=',c)
a = False
b = True
c = a and b
print(a,'AND',b,' =',c)
a = True
b = True
c = a and b
print(a,' AND',b,' =',c)

# akan true jika salah satu true, sisanya false
print('====XOR====')
a = False
b = False
c = a ^ b
print(a,'XOR',b,'=',c)
a = False
b = True
c = a ^ b
print(a,'XOR',b,' =',c)
a = True
b = False
c = a ^ b
print(a,' XOR',b,'=',c)
a = True
b = True
c = a ^ b
print(a,' XOR',b,' =',c)
