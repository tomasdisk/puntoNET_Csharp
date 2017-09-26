using System;

namespace ej_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 9 */
            /* "100".Length corresponde a la respuesta de la funcion "Length" que devuelve la cantidadd de caracteres del string "100" */
            System.Console.WriteLine("100".Length);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 10 */
            /* si, se puede hacer un "ReadLine" dentro del "WriteLine" y almacenar su respuesta en "st" */
            String st;
            Console.WriteLine("Ingrese un texto:");
            Console.WriteLine(st = Console.ReadLine());
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 10 */
            /* si, se puede hacer un "ReadLine" dentro del "WriteLine" y almacenar su respuesta en "st" */
            Console.WriteLine("Ingrese un texto simetrico respecto del caracter \" \" (blanco):");
            st = Console.ReadLine();
            if (st.Length % 2 == 1 && st[st.Length / 2] == ' ')
            {
                int i;
                for (i = 0; i < st.Length/2; i++)
                {
                    if (st[i] != st[st.Length - 1 - i])
                    {
                        System.Console.WriteLine(st[i] + " <> " + st[st.Length - 1 - i]);
                        break;
                    }else
                    {
                        System.Console.WriteLine(st[i] + " = " + st[st.Length - 1 - i]);
                    }
                }
                if (i == st.Length / 2)
                {
                    System.Console.WriteLine("La frase es simetrica.");
                }else{
                    System.Console.WriteLine("La frase NO es simetrica.");
                }
                
            }else
            {
                System.Console.WriteLine("La frase NO es simetrica.");
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 12 */
            /* si, se puede hacer un "ReadLine" dentro del "WriteLine" y almacenar su respuesta en "st" */
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 17 == 0)
                {
                    System.Console.Write(i + "(17) ");
                }
                if (i % 29 == 0)
                {
                    System.Console.Write(i + "(29) ");
                }
            }
            System.Console.WriteLine("\nPresione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
}
