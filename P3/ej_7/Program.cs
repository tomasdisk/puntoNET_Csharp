using System;
using System.Collections;

namespace ej_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 7 */
            // si el operando es un float, la division por cero da 'infinito'
            int x = 0;
            try
            {
                Console.WriteLine(1.0 / x);
                Console.WriteLine(1 / x); // la exepcion se propago en esta linea
                Console.WriteLine("Ok");
            }
            catch{}
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 8 */
            // se propaga la exepcion al que llamo el metodo, pero antes se ejecuta el finally
            try
            {
                metodo1();
            }
            catch
            {
                Console.WriteLine("método 1 propagó una excepción no tratada");
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 9 */
            Console.WriteLine("ingrese una expresion matematica binaria simple:");
            String expr = Console.ReadLine();
            char op = '.';
            foreach (char c in expr)
            {
                if (c == '-' || c == '+' || c == '*' || c == '/')
                    op = c;
            }
            if (op == '.'){
                try{
                    Console.WriteLine("Resultado: {0}", int.Parse(expr));
                }
                catch{
                    Console.WriteLine("Expresion no valida.");
                }
                finally{
                    Console.WriteLine("Operador no encontrado.");
                }
            }
            else{
                try
                {
                    String[] nums = expr.Split(op);
                    switch (op)
                    {
                        case '+': Console.WriteLine("Resultado: {0}", float.Parse(nums[0]) + float.Parse(nums[1])); break;
                        case '-': Console.WriteLine("Resultado: {0}", float.Parse(nums[0]) - float.Parse(nums[1])); break;
                        case '*': Console.WriteLine("Resultado: {0}", float.Parse(nums[0]) * float.Parse(nums[1])); break;
                        case '/': Console.WriteLine("Resultado: {0}", float.Parse(nums[0]) / float.Parse(nums[1])); break;
                        default: Console.WriteLine("Operador no encontrado."); break;
                    }
                }
                catch
                {
                    Console.WriteLine("Operandos no validos.");
                }
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 10 */
            // al crearse con int[] se cargan 32 bits por cada numreo y al crearse con byte[] se cargan 8 bits por cada numero. el bit mas significativo se carga en el indice mayor del BitArray. 
            int[] vectorDeInt = new int[] { 5, 255 };
            Console.WriteLine("BitArray construido a partir " +
            "del vector de enteros {5,255}");
            BitArray ba1 = new BitArray(vectorDeInt);
            for (int i = 0; i < ba1.Count; i++)
            {
                Console.WriteLine("posicion {0,2} valor {1}", i, ba1[i]);
            }
            byte[] vectorDeByte = new byte[] { 5, 255 };
            Console.WriteLine("BitArray construido a partir " +
            "del vector de bytes {5,255}");
            BitArray ba2 = new BitArray(vectorDeByte);
            for (int i = 0; i < ba2.Count; i++)
            {
                Console.WriteLine("posicion {0,2} valor {1}", i, ba2[i]);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }

        // metodo el ej8
        static void metodo1()
        {
            int b = 0;
            try
            {
                b=5/b;
            }
            finally
            {
                Console.WriteLine("bloque finally");
            }
        }
    }
}
