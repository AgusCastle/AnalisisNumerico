import pdb
from math import pi, asin, sqrt
a,b = input("Intervalo. (a,b): ").split(",")
a = float(a)
b = float(b)
if b < a:
    a, b = b, a
repeat = int(input("Numero de repeticiones: "))
V = lambda h: 10 * ( 0.5 * pi - asin(h) - h * sqrt(1 - h**2) ) - 12.4
if (V(a) * V(b)) < 0:
        i = 1
        V_x = 5
        xm = 0
        while abs(V_x) > 0.01 and i <= repeat:
            xm = (a + b) / 2
            V_x = V(xm)
            if V(a) * V_x < 0:
                b = xm
            else:
                a = xm
            i += 1

        if abs(V_x) <= 0.01:
            print ("\n\tLa raiz es: {}.En el intervalo: [{},{}]. Iteraciones: {}".format(xm, a, b, i))
        if i >= repeat:
            print ("Faltan más ciclos. Raiz aproximada: {}".format(xm))

else:
    print("No hay raices en el intervalo [{}, {}]".format(a, b))
