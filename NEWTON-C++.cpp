#include <iostream>
#include <cmath>

using namespace std;

float Funcion(float x){
	return exp(x) - pow(2,-x) + 2 * cos(x) - 6;
}

float Derivada(float x){
	return exp(x) + (pow(2,-x) * log1p(2)) - (2 * cos(x));
}

int main(int argc, char const *argv[])
{
	float a, tol, fx, fdx, x, aux;
	int iteracion, cont = 0;
	cout << "Dame un punto: ";
	cin >> a;
	cout << "Dame la tolerancia: ";
	cin >> tol;
	cout << "Dame el numero de veces que se llevara acabo el proceso: ";
	cin >> iteracion;
	do{
		fx = Funcion(a);
		fdx = Derivada(a);
		x = a - (fx/fdx);
		aux = a;
		a = x;
		cont++;
	}while(abs(fx) > tol && cont < iteracion);

	if(abs(fx) <= tol)
		cout << "La raiz se encuentra "<< aux <<" y la funcion vale " << fx <<"\n Se usaron "<< cont <<" iteraciones";
	if (cont >= iteracion)
		cout << "Te faltaron mas iteraciones";
}