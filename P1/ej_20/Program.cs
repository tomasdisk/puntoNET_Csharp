using System;

namespace ej_20
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 20 */            
            /* 1  */ {int a, b, c;}
            /* 2  */ {int a; int b; int c, d;}
            /* 3  */ {int a = 1; int b = 2; int c = 3;}
            /* 4  */ {int b; int c; int a = b = c = 1;}
            /* 5  */ {int c; int a, b = c = 1;}
            /* 6  */ {int c; int a = 2, b = c = 1;}
            /* 7  */ {int a = 2, b, c, d = 2 * a;}
            /* 8  */ /* {int a = 2, int b = 3, int c = 4;} => habria que cmabiar las ',' por ';' */
            /* 9  */ /* {int a = 2; b = 3; c = 4;} => habria que cmabiar las ';' por ',' */
            /* 10 */ /* {int a; int c = a;} => se asigna a 'c' el valor de la variable 'a' que no fue inicializada */
            /* 11 */ /* {char c = 'A', string st = "Hola";} => habria que cmabiar ',' por ';' */
            /* 12 */ {char c = 'A'; string st = "Hola";}
            /* 13 */ /* {char c = 'A', st = "Hola";}  => se asigna a una variable 'char' un string */
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey(true);

            /* ejercicio 21 */
            /* si se descomenta la linea siguente el 'for' falla porque ya existe una variable 'j' en el bloque que contiene al bucle */
            /* int j = 0; */
            for (int j = 1; j <= 10;)
            {
                Console.WriteLine(j++);
            }
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey(true);

            /* ejercicio 22 */
            /* en el primer 'if' a la variable 'i' se le decremente una unidad previo a la evaluacion de la condicion. En el segundo 'if' se le incremente una unidad postriormente a la evaluacion de la condicion*/
            int i = 1;
            if (--i == 0)
            {
                Console.WriteLine("cero");
            }
            if (i++ == 0)
            {
                Console.WriteLine("cero");
            }
            Console.WriteLine(i);
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey(true);

            /* fin */
            Console.Write("bye..");
        }
    }
}
