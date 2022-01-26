print("Escribe el primer número")
u = int(input())

print("Escribe el segundo número")
d = int(input())

print("Escribe el tercer número")
t= int(input())

if u > d and  u > t:
    print("El primer número es el más grande")
elif d > t and d > u:
    print("El segundo número es el más grande")
elif t > u and t > d:
    print("El segundo número es el más grande")
else:
    print("Escribiste el mismo número XDXDXD")
