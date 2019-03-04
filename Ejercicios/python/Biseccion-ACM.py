"""
Metodo de la biseccion
Acevedo Bringas Luis Esteban
Arellano Martinez Leonardo Antonio
Castillo Munguia Agustin
"""
funcion = lambda x: x**4 - (2*(x**3)) - (4*(x**2)) + 4*x +4
print("Calculo de raices por Biseccion")
a = float(input("Ingresa el punto a: "))
b = float(input("Ingresa el punto b: "))
if b < a:
	aux = a
	a = b
	b = aux
print("Intervalo[{},{}]".format(a,b))
tolerancia = float(input("Ingresa la Tolerancia: "))
iterador = int(input("El numero de iteraciones a realizar: "))
f_a = funcion(a)
f_b = funcion(b)
if f_a * f_b < 0:
	f_x = 5
	contador = 1
	while (float(abs(f_x)) > tolerancia) and (contador < iterador):
		Pm = (a + b) / 2
		f_x = funcion(Pm)
		if f_a * f_x < 0:
			b = Pm
			contador += 1
		else:
			a = Pm
			contador += 1
	if contador >= iterador:
		print("Faltaron mas iteraciones")
	if (abs(f_x) <= tolerancia):
		print("\n\nLa raiz se encuentra {:.4f} \n\n El valor de la funcion fue {}".format(Pm,round(f_x,6)))
		print("Se itero {} veces.".format(contador))
else:
	print("No hay raices en este Intervalo")
	