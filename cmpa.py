print("Escribe el primer dígito")
a = int(input())

print("Escribe el segundo dígito")
b = int(input())

if a>b:
    r=a/b
    print(f"{a} / {b} = {r}")
elif a<b:
    r=b/a
    print(f"{b} / {a} = {r}")
else:
    print("Escribiste el mismo número")
