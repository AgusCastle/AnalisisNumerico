a,b = input("Intervalo. (a,b): ").split(",")
a = float(a)
b = float(b)
repeat = int(input("Numero de repeticiones: "))
func = lambda x: x ** 3 + 4 * (x ** 2) - 10
if (func(a) * func(b)) < 0:
        i = 1
        func_x = 5
        while abs(func_x) > 0.001 and i <= repeat:
            xm = (a + b) / 2
            func_x = func(xm)
            if func(a) * func_x < 0:
                b = xm
            else:
                a = xm
            i += 1

        if abs(func_x) <= 0.001:
            print ("La raiz es: " + str(xm))
        else:
            print ("Faltan más ciclos. Raiz aproximada: " + str(xm))

else:
    print("No hay raices en el intervalo [{}, {}]".format(a, b))
