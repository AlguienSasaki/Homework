a = int(input("Escribe el primer dígito: "))
b = int(input("Escribe el segundo dígito: "))

if a >= b:
    r=a/b
    print(f"{a} / {b} = {r}")
else:
    r=b/a
    print(f"{b} / {a} = {r}")
