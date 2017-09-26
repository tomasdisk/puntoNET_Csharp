using System;

namespace ej_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 13 */
            /* el operador division actua segun el tipo de datos de los operando involucrados */
            /* el operador '+' funciona para concatenar string con otros string o variables numericas */
            Console.WriteLine("10/3 = 10 / 3 => se produce una divicion entera porque ambos operandos son enteros");
            Console.WriteLine("10/3 = " + 10 / 3);
            Console.WriteLine("10.0/3 = 10.0 / 3 => se produce una divicion con decimales porque uno de los operando es float");
            Console.WriteLine("10.0/3 = " + 10.0 / 3);
            Console.WriteLine("10/3.0 = 10 / 3.0 => se produce una divicion con decimales porque uno de los operando es float");
            Console.WriteLine("10/3.0 = " + 10 / 3.0);
            int a=10,b=3;
            Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
            Console.WriteLine("entonces a/b = " + a/b);
            double c=3;
            Console.WriteLine("Si c es una variable double, c=3");
            Console.WriteLine("entonces a/c = " + a/c);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey(true);

            /* ejercicio 14 */
            Console.WriteLine("Ingrese un numero entero:");
            try
            {
            int num = int.Parse(Console.ReadLine());
            for (int i = num; i > 0; i--)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            }
            catch (System.Exception)
            {
                Console.Write("Lo ingresado no fue un numero.");
            }
            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey(true);

            /* ejercicio 15 */
            /* la consola lee los decimales con ',' => ejemplo "5,5" en vez de "5.5" */
            try
            {
                Console.WriteLine("Ingrese el primer numero:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:");
                double num2 = double.Parse(Console.ReadLine());
                double res = num1 + num2;
                Console.Write("el resultado de " + num1 + " + " + num2 + " es: " + res);
            }
            catch (System.Exception)
            {
                Console.Write("Lo ingresado no fue un numero.");
            }
            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey(true);

            /* ejercicio 16 */
            Console.WriteLine("Ingrese un numero entero:");
            try
            {
                int num = int.Parse(Console.ReadLine());
                num *= 365;
                Console.WriteLine("numero completo => " + num);
                String st = Convert.ToString(num);
                for (int i = st.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(st[i]);
                }
            }
            catch (System.Exception)
            {
                Console.Write("Lo ingresado no fue un numero.\n");
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey(true);

            /* ejercicio 17 */
            /* la consola lee los decimales con ',' => ejemplo "5,5" en vez de "5.5" */
            try
            {
                Console.WriteLine("Ingrese el primer numero:");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero:");
                double num2 = double.Parse(Console.ReadLine());
                int res = Convert.ToInt32(num1 / num2);
                Console.Write("el resultado de " + num1 + " / " + num2 + " es: " + res);
            }
            catch (System.Exception)
            {
                Console.Write("Lo ingresado no fue un numero.");
            }
            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey(true);

            /* ejercicio 18 */
            Console.WriteLine("Ingrese un año:");
            try
            {  
                int año;
                año = int.Parse(Console.ReadLine());
                if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
                {
                    Console.WriteLine("El año {0} es bisiesto.", año);
                }
                else
                {
                    Console.WriteLine("El año {0} no es bisiesto.", año);
                }
            }
            catch (System.Exception)
            {
                Console.Write("Lo ingresado no fue un numero.\n");
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey(true);

            /* ejercicio 19 */
            /* la expresion "if ((b != 0) & (a / b > 5)) Console.WriteLine(a / b);" tiene dos problemas, el primero es la perdida de precicion con la divicion entera (pero eso ya se analizo en ejercicios ateriores). El otro problemqa es que si la variables 'b' es '0' la condicion posterior al '&' tira la exepcion "System.DivideByZeroException". Para solucionar eso hay que remplazar el '&' por '&&' que no consulta la segunda condicion del 'if' al ver que la primera ya es falsa. Otra solucion hubiera sido utilizar un try-catch para la exepcion. */
            a = 19;
            b = 0;
            Console.WriteLine("a = {0} y b = {1}.", a, b);
            if ((b != 0) && (a / b > 5)) Console.WriteLine(a / b);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey(true);

            /* fin */
            Console.Write("bye..");
        }
    }
}
