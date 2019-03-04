//Programa metodo de Biseccion
#include <iostream>
#include <stdio.h>
#include<stdlib.h>
#include <math.h>
using namespace std;
double funcion (double entrada)
    {
        double salida;
        salida=pow(entrada,2)-4*pow(entrada,1)+4-log(entrada);
        return salida;
    }
main()
{
    double a, aux, b, pm, fa, fb, fx, tolerancia;
    int iteracion, contador;
    system("cls");
    cout<<"\n \t Programa que calcula raices por medio de la Biseccion";
    cout<<"\n Dame el valor de a ";
    cin>>a;
    cout<<"\n Dame el valor de b ";
    cin>>b;
    if(b<a)
        {
            aux=a;
            a=b;
            b=aux;
        }
    cout<<"\n El intervalo a trabajar es ["<<a<<" , "<<b<<"]"<<endl;
    cout<<"\n Dame la tolerancia o la precision que se necesita ";
    cin>>tolerancia;
    cout<<"\n Cuantas veces se tiene que hacer este proceso ";
    cin>>iteracion;
    fa=funcion(a);
    fb=funcion(b);
    if(fa*fb<0)
        {
            fx=8;
            contador=1;
            while((fabs(fx)>tolerancia)&&(contador<iteracion))
                {
                    pm=(a+b)/2;
                    fx=funcion(pm);
                    if(fa*fx<0)
                    {
                        b=pm;
                        contador++;
                    }
                    else
                    {
                        a=pm;
                        contador=contador+1;
                    }
                }
            if(contador>=iteracion)
            {
                cout <<"\n Faltaron mas iteraciones por hacer";
            }
            if (fabs(fx)<=tolerancia)
            {
                cout<<"\n La raiz se encuentra en "<<pm<< " El valor de la funcion fue "<<fx<<endl;
                cout<<"\n Se usaron "<< contador<< " veces"<<endl;
            }
        }
    else
        {
            cout<<"\n No hay raices en este intervalo dado";
        }
    cout<<"\n Fin del programa\n ";
    system("pause");
}// fin del programa












