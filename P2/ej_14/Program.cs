using System;
using System.Text;

namespace ej_14
{
    class Program
    {
        enum Meses{Enero,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre,Octubre,Noviembre,Diciembre}
        enum Dias { lunes, martes, miercoles, jueves, viernes }
        static void Main(string[] args)
        {
            /* ejercicio 14 */
            int[] v1 = new int[] { 10, 20, 30 };
            int[] v2 = v1;
            Console.WriteLine(v1 == v2);        // True
            v2[0] = 15;
            Console.WriteLine(v1 == v2);        // True
            v2 = new int[] { 15, 20, 30 };
            Console.WriteLine(v1 == v2);        // False
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 15 */
            object[] v = new object[10];
            v[0] = new StringBuilder("Net");
            for (int i = 1; i < 10; i++)
            {
                v[i] = v[i - 1];
            }
            (v[5] as StringBuilder).Insert(0, "Framework .");
            foreach (StringBuilder s in v)
                Console.WriteLine(s);
            //dibuje el estado de la pila y la mem. heap en este punto de la ejecución
            // pila: |  heap:
            //       |
            // v   --|-> [[obj1],[obj1],[obj1],[obj1],[obj1],[obj1],[obj1],[obj1],[obj1],[obj1]]
            //       |   obj1 => "Framework .Net"
            //       |
            v[5] = new StringBuilder("CSharp");
            foreach (StringBuilder s in v)
                Console.WriteLine(s);
            //dibuje el estado de la pila y la mem. heap en este punto de la ejecución
            // pila:   |   heap:
            //         |
            // v[]   --|-> [[obj1],[obj1],[obj1],[obj1],[obj1],[obj2],[obj1],[obj1],[obj1],[obj1]]
            //         |   obj1 => "Framework .Net"
            //         |   obj2 => "CSharp"
            //         |
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 16 */
            Meses m;
            for (int i = 12 - 1; i >= 0 ; i--)
            {
                m = (Meses)i;
                Console.WriteLine(m);
            }
            for (int i = 0; i < 12; i++)
            {
                if ((i+1) % 2 == 0)
                {
                    m = (Meses)i;
                    Console.WriteLine(m);
                }
            }
            Console.WriteLine("Ingrese un mes:");
            string st = Console.ReadLine();
            int j;
            for (j = 0; j < 12; j++)
            {
                m = (Meses)j;
                if (st.ToUpper()==m.ToString().ToUpper())
                {
                    Console.WriteLine("{0} es un mes", st);
                    break;
                }    
            }
            if (j==12)
                Console.WriteLine("{0} NO es un mes", st);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 17 */
            // el foreach no funciona porque los enumerativos no son una coleccion.
            // foreach (Dias d in Dias) Console.WriteLine(d);
            // los enumeraticos no tiene definido el atributo "Length"
            // for (int i = 0; i < Dias.Length; i++) Console.WriteLine((Dias)i);
            // la siguiente es la unica opcion que funciona
            for (Dias d = Dias.lunes; d <= Dias.viernes; d++) Console.WriteLine(d);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 18 */
            piramide(8);
            piramide(3);
            piramide(25);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 19 */
            try
            {
            Console.WriteLine(fac(int.Parse(args[0])));           
            Console.WriteLine(facr(int.Parse(args[0])));
            }
            catch (System.Exception)
            {
                Console.WriteLine("No se ingreso ningun paramtro o no fue un numero!");
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 20 */
            try
            {
                long r;
                fac(int.Parse(args[0]), out r);
                Console.WriteLine(r);
                facr(int.Parse(args[0]), out r);
                Console.WriteLine(r);
            }
            catch (System.Exception)
            {
                Console.WriteLine("No se ingreso ningun paramtro o no fue un numero!");
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }

        // metodo que imprime piramide del ej18
        static void piramide(int altura)
        {
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < altura+i; j++)
                {
                    if (altura-j > i+1)
                        Console.Write(' ');
                    else
                        Console.Write('*');
                }
                Console.Write('\n');
            }
        }
        // metodo factorial del ej19
        static long fac(int n)
        {
            long fact = n;
            for (int i= n - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            return fact;
        }
        // metodo factorial recursivo del ej19
        static long facr(int n)
        {
            if (n==1)
                return 1;
            else
                return n * facr(n-1);
        }
        // metodo factorial del ej20
        static void fac(int n, out long f)
        {
            f = n;
            for (int i = n - 1; i >= 1; i--)
            {
                f = f * i;
            }
        }
        // metodo factorial recursivo del ej20
        static void facr(int n, out long f)
        {
            if (n == 1)
                f = 1;
            else{
                long r;
                facr(n - 1, out r);
                f = n * r;
            }
        }
    }
}
