using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, aux, b, pm, fa, fb, fx, tolerancia;
            int iteracion, contador;

            Console.WriteLine("Metodo de la biseccion");
            Console.WriteLine("Ingresa el valor de a: ");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de b: ");
            b = Double.Parse(Console.ReadLine());
            if(b > a)
            {
                aux = a;
                a = b;
                b = aux;
            }
            fa = Funcion(a);
            fb = Funcion(b);
            Console.WriteLine("Dame a tolerancia: ");
            tolerancia = Double.Parse(Console.ReadLine());
            Console.WriteLine("Dame a iteraccion: ");
            iteracion = Int32.Parse(Console.ReadLine());
            if ((fa * fb) < 0)
            {
                fx = 5;
                contador = 1;
                while(Math.Abs(fx) > tolerancia && (contador < iteracion))
                {
                    pm = (a + b) / 2;
                    fx = Funcion(pm);
                    if(fa*fx < 0)
                    {
                        b = pm;
                        contador++;
                    }
                    else
                    {
                        a = pm;
                        contador++;
                    }
                    if (contador >= iteracion)
                        Console.WriteLine("FALTAN ITERACVIONS POR HACER");

                    if(Math.Abs(fx) <= tolerancia)
                    {
                        Console.WriteLine("La raiz se encuentra en " + pm + "El valor de la funcion fue " + fx);
                        Console.WriteLine("Se usaron " + contador + "iteraciones");
                    }
                }
            }else
            {
                Console.WriteLine("No hay Raices en el iintervalo");
            }
            Console.ReadKey();
        }
        static double Funcion(double x)
        {
            return (Math.Pow(x, 3) - Math.Pow(x, 2) - (14 * x) + 14);
        }
    }
}
