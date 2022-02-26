# la condición anidada es basicamente meter un condional dentro de otro, así de fácil

u = int(input("Ingresa e un: "))

d = int(input("Ingresa e un: "))

t = int(input("Ingresa e un: "))


if u > d  and u > t:
    if d > u and d > t:
        print ("2")
    else:
        print ("3")
else:
    print ("1")
