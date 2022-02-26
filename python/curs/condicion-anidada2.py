# la condición anidada es basicamente meter un condional dentro de otro, así de fácil

u = int(input("Ingresa e un: "))

d = int(input("Ingresa e un: "))

t = int(input("Ingresa e un: "))


if u > d  :
    if u > t:
        print ("EL 1 es el más grande")
elif d > u:
    if d > t:
        print ("EL 2 es el más grande")
elif t > d:
    if t > u:
        print("EL 3 es el más grande")
else:
    print ("Escribiste el mismo número xdxd")
