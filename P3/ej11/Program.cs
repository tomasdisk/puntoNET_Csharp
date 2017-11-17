using System;
using System.Collections;
using System.Text;

namespace ej11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 11 */
            Console.WriteLine("ingrese un caracter");
            byte[] c = {(byte)Console.ReadKey().KeyChar};
            System.Console.WriteLine();
            BitArray ba = new BitArray(c);
            for (int i = 0; i < ba.Count; i++)
            {
                Console.WriteLine("posicion {0,2} valor {1}", i, ba[i]);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 12 */
            Console.WriteLine("ingrese la primera palabra:");
            String p1 = Console.ReadLine();
            Console.WriteLine("ingrese la segunda palabra:");
            String p2 = Console.ReadLine();
            int l = p1.Length;
            if (p2.Length < l) l = p2.Length;
            byte[] b1 = new byte[l];
            byte[] b2 = new byte[l];
            for (int i = 0; i < l; i++)
            {
                b1[i] = (byte)p1[i];
                b2[i] = (byte)p2[i];
            }
            BitArray ba1 = new BitArray(b1);
            BitArray ba2 = new BitArray(b2);
            for (int i = 0; i < ba1.Count; i++)
            {
                Console.WriteLine("posicion {0,2} valor {1}", i, ba1.And(ba2)[i]);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 13 */
            Console.WriteLine("Ingrese un numero:");
            int n = 0;
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Lo ingresado no fue un numero.");
            }
            int b = 2;
            Stack s = new Stack();
            while (n > b)
            {
                s.Push(n % b);
                n /= b;
            }
            s.Push(n % b);
            s.Push(n/b);
            while (s.Count > 0)
            {
                Console.Write(s.Pop());
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 14 */
            Console.WriteLine("ingrese una palabra:");
            String p = Console.ReadLine();
            Queue q = new Queue();
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '(')
                {
                    q.Enqueue('(');
                }else{
                    if (p[i] == ')')
                    {
                        if (q.Count == 0)
                        {
                            q.Enqueue('(');
                            break;
                        }
                        q.Dequeue();
                    }
                }
            }
            if (q.Count == 0)
            {
                Console.WriteLine("Parentesis balanceados.");
            }else
            {
                Console.WriteLine("Parentesis NO balanceados.");
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 15 */
            // pasa a mayusculas primero. encripta en mayuculas (solo las letras) deplanzando cada letra el valor de la clave. en caso de overflow: 'Z' => 'A'
            Console.WriteLine("ingrese un texto:");
            StringBuilder t = new StringBuilder(Console.ReadLine().ToUpper());
            Queue clave = new Queue();
            clave.Enqueue(5);
            clave.Enqueue(3);
            clave.Enqueue(9);
            clave.Enqueue(7);
            int shift = 0;
            int ch = 0 ;
            for (int i = 0; i < t.Length; i++)
            {   
                shift = (int)clave.Dequeue(); // la clave circula igual si no son letras
                clave.Enqueue(shift);
                if (t[i] >= 'A' && t[i] <= 'Z')
                {
                    ch = (int)t[i]+shift;
                    if (ch >90) ch -= 26; // si llego a 'Z' resta todo el alfabeto(ingles)
                    t[i] = (char)ch;
                }
            }
            Console.WriteLine(t);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
}
