using System;

namespace ej_21
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 21 */
            Console.WriteLine(fib(9));
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 22 */
            Console.WriteLine(comb(13,3));
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 23 */
            int number = 150;
            for (int i = 0; i < number; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }

        // metodo serie de Fibonacci del ej21
        static int fib(int n)
        {
            if (n <= 2)
                return 1;
            else
                return fib(n-1) + fib(n-2);
        }
        // metodo factorial recursivo del ej22
        static long facr(int n)
        {
            if (n==1)
                return 1;
            else
                return n * facr(n-1);
        }
        // metodo factorial recursivo del ej22
        static long comb(int n, int k)
        {
            return facr(n)/(facr(n-k)*facr(k));
        }
        // metodo que calcuala si un numero es primo del ej23
        static bool EsPrimo(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;

            if (n % 2 == 0) return false; // Even number     

            for (int i = 2; i < Math.Sqrt(n); i++)
            { // Advance from two to include correct calculation for '4'
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}