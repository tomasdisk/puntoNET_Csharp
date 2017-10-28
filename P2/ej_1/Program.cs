using System;

namespace ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 1 */
            char c1 = 'A';          // se declara un char (tipo valor).
            string st1 = "A";       // se declara un objero strong (tipo fererencia).
            object o1 = c1;         // se hace un boxing del char a un objeto.
            object o2 = st1;        // como los dos son objetos no hay boxing o unboxing.
            char c2 = (char)o1;     // se hace un unboxing al pasar de un Object a un char de tipo valor.
            string st2 = (string)o2;// se hace un casteo a string pero ambos son objetos.
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 2 */
            // los Writelne imprimen cosas distintas porque el el operador '=' en la linea 1 asigna la referencia del vector v1 y en la linea dos asigna el valor del objeto obj1.
            int[] v1 = new int[1] { 1 };
            int[] v2 = v1;                  // linea 1
            v1[0] = 2;
            Console.Write(v1[0]);
            Console.WriteLine(" " + v2[0]);
            object obj1 = 1;
            object obj2 = obj1;             // linea 2
            obj1 = 2;
            Console.Write(obj1);
            Console.WriteLine(" " + obj2);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 3 */
            int sum = 0;
            int i = 1;
            while (i <= 10) // el ';' al final de esta linea hace que el bucle este vacio por lo que nunca se cumple la condicion y continua infinitamente.
            {
                sum += i++;
            }
            Console.WriteLine("sumatoria del 1 al 10 ==> " + sum);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 4 */
            // el vector 'args' nunca esta en 'null' pero puede contrner cero o mas parametros.
            Console.WriteLine(args == null);
            Console.WriteLine(args.Length);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 5 */
            // crea un vector de cero elementos de tipo int. no se le asigna el valor 'null'.
            int[] vector = new int[0];
            Console.WriteLine(vector == null);
            Console.WriteLine(vector.Length);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 6 */
            // si no se le pasa un parametro al programa salta una excepcion ' System.IndexOutOfRangeException' por lo que se le agrogo un try-catch.
            try
            {
                Console.WriteLine("¡Hola {0}!", args[0]);
            }
            catch (System.Exception)
            {
                Console.WriteLine("¡Hola, no se pasaraon parametros!");
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 7 */
            char c;
            string st;
            //c = "";               // para declarar run caracter hay que usar comillas simple (').
            //c = '';               // no se puede declarar un caracter vacio.
            //c = null;             // es una variable de tipo valor, no acepta el valor 'null'.
            st = "";                // se pueden declarar string vacios.
            //st = '';              // para declarar un string hay que usar comillas dobles(").
            st = null;              // los string son de tipo referencia por lo que aceptan el valor 'null'.
            //st = (char)65;        // no se puede tranformar implisitamente un 'char' en 'string'.
            //st = (string)65;      // no se puede castear un numero a string de esta forma.
            st = 47.ToString();     // la funcion 'ToString()' se encarga de esta tarea.
            st = 47.89.ToString();
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
}
