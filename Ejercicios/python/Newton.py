from math import cos, sin
Funcion = lambda x : 2*x*(cos(2*x)) - (x-1)**2
Derivada = lambda x : -4*x*sin(2*x) - (2*x) + 2*cos(2*x) + 2
print("Metodo de Newton-Rhapson")
a = float(input("Dame un punto: "))
tolerancia = float(input("Dame la tolerancia o la presicion: "))
iteracion = int(input("Cuantas veces quieres que se haga el procedimiento: "))
fp = 5
contador = 0
while (abs(fp) > tolerancia) and (contador < iteracion):
    fp = Funcion(a)
    fdp = Derivada(a)
    x = a - (fp/fdp)
    aux = a
    a = x
    contador += 1
if abs(fp) <= tolerancia:
    print("La raiz se encuentra en {} y la funcion vale {}".format(round(aux,8),round(fp,8)))
    print("Se uso {} iteraciones.".format(contador))
if contador >= iteracion:
    print("Te faltaron mas iteraciones.")
