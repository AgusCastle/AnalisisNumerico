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
            double a, b, tol, fdeb, fdea, p;
            int iterador, Cont;
            Console.Write("Dame el primer punto: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame el segundo punto: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame Tolerancia: ");
            tol = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dame iterador: ");
            iterador = Convert.ToInt32(Console.ReadLine());
            Cont = 1;
            do
            {
                fdea = Funcion(a);
                fdeb = Funcion(b);
                p = b - ((fdeb * (b - a)) / (fdeb - fdea));
                a = b;
                b = p;
                Cont++;

            } while ((Math.Abs(fdeb) >= tol) && Cont < iterador);

            if (Math.Abs(fdeb) < tol)
                Console.WriteLine("La raiz esta en " + a + " y la funcion vale " + fdeb + ". \n Se usaron " + Cont + " iteraciones");
            Console.ReadKey();
        }
        static double Funcion(double x)
        {
            return (Math.Pow(x, 3) - Math.Pow(x, 2) - (14 * x) + 14);
        }
    }
}
