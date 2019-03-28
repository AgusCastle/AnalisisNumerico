using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEWTON
{
    class FuncionDada
    {
        public double Funcion(double x)
        {
            return (Math.Pow(x, 3) - Math.Pow(x, 2) - (14 * x) + 14);
        }

        public double Derivada(double x)
        {
            return (3 * (Math.Pow(x,2)) - 2 * x - 14);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            FuncionDada f = new FuncionDada();
            float tol;
            double fp, fdx, a, x, aux;
            int contador = 0, iteracion;
            Console.WriteLine("PROGRAMA DE NEWTON-RHAPSON");
            Console.Write("Dame un punto: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Dame la tolerancia o la precision: ");
            tol = float.Parse(Console.ReadLine());
            Console.Write("Cuantas veces tiene que hacer esta cuenta: ");
            iteracion = Convert.ToInt32(Console.ReadLine());
            do
            {
                fp = f.Funcion(a);
                fdx = f.Derivada(a);
                x = a - (fp / fdx);
                aux = a;
                a = x;
                contador++;
            } while ((Math.Abs(fp) > tol) && contador < iteracion);

            if (Math.Abs(fp) <= tol)
            {
                Console.WriteLine("La raiz se encuentra en " + aux + " y la funcion vale " + fp);
                Console.WriteLine("Se uso " + contador + " itearciones");
            }
            if (contador >= iteracion)
            {
                Console.WriteLine("Te faltaron mas iteraciones");
            }
        }catch (Exception error)
            {
                Console.Write(error.Message);
            }
    Console.ReadKey();

        }
    }
}
