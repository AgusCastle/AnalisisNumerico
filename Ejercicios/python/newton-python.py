from math import exp, cos, sin, log1p

func = lambda x: exp(x) - (2 ** -x) + (2 * cos(x)) - 6
derivative = lambda x: exp(x) + ((2 ** -x) * log1p(2)) - (2 * sin(x))
point = float(input("Punto inicial: "))

while (abs(func(point)) > 0.001):
	point = point - (func(point) / derivative(point))

if abs(func(point) <= 0.001):
	message = """El punto buscado es: {}
el valor de la funcion es: {}""".format(point, func(point))
	print (message)
