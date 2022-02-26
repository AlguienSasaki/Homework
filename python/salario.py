h = int(input("Ingresa tus horas trabajadas: "))
he = int(input("Ingresa tus horas extras: "))

ch = h * 50 
che = he * 80 

d = ch + che
des = d * 0.05
sueldo = d - des
print(f"Trabajaste {h} horas, {he} horas extras por lo cual tu salario sería de {d} de no ser por el descuento del 5%. Tu sueldo final será de {sueldo} ")
