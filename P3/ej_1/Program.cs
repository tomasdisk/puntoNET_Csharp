using System;
using System.Text;
using System.IO;
using System.Collections;

namespace ej_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 1 */
            // las propiedades de Console sireven para cambiar el tamano de la consola o controlar el cursor
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Console.CursorLeft = Console.WindowWidth - 1 - i;
                Console.CursorTop = i * 2;
                Console.Write(i);
            }
            Console.CursorLeft = 0;
            Console.CursorVisible = false;
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 2 */
            // muestra la tecla ingresada con el modificador aplicado y el caracter que la representa
            Console.Clear();
            Console.CursorVisible = false;
            ConsoleKeyInfo k = Console.ReadKey(true);
            while (k.Key != ConsoleKey.End)
            {
                Console.Clear();
                Console.Write("{0,-10} {1,-10} {2,-10}", k.Modifiers, k.Key, k.KeyChar);
                k = Console.ReadKey(true);
            }
            Console.CursorLeft = 0;
            Console.CursorVisible = false;
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 3 */
            ConsoleKeyInfo q = Console.ReadKey(true);
            StringBuilder st = new StringBuilder("");
            while (q.Key != ConsoleKey.Enter)
            {
                Console.Write(q.KeyChar.ToString().ToUpper());
                st.Append(q.KeyChar);
                q = Console.ReadKey(true);
            }
            System.Console.WriteLine("\n{0}",st);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 4 */
            // falta terminar.. habria que guardar las lineas en buffers?
            /*
            int count = 0;
            ConsoleKeyInfo t = Console.ReadKey(true);

            while (count < 10 && t.Key != ConsoleKey.Escape)
            {
                Console.Write(t.KeyChar);
                Console.CursorLeft = 0; // no es suficiente, con esto los caracteres se pisan
                if (t.Key == ConsoleKey.Enter)
                {
                    count++;
                    Console.CursorTop = Console.CursorTop-1; // creo q las lineas se pisan y termina generando una exepcion
                }
                t = Console.ReadKey();
            }
            Console.CursorLeft = 0;
            Console.CursorVisible = false;
            */
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 5 */
            // archifo fuente r.txt y archivo destino w.txt
            Console.WriteLine("ingrese nombre del archuvo fuente.");
            String sr = Console.ReadLine();
            Console.WriteLine("ingrese nombre del archuvo destino.");
            String ds = Console.ReadLine();
                StreamReader r = null;
                StreamWriter w = null;
            try
            {
                r = new StreamReader(sr);
                w = new StreamWriter(ds);
                ArrayList list = new ArrayList();
                while (!r.EndOfStream)
                {
                    String line = r.ReadLine();
                    list.AddRange(line.Split(' '));
                }
                list.Sort();
                foreach (String s in list)
                {
                    w.WriteLine(s);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (r != null)r.Close();
                if (w != null) w.Close();
            }
            

            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 6 */
            Console.WriteLine("ingrese un numro");
            String num = Console.ReadLine();
            int sum = 0;
            while (num != "")
            {
                try
                {
                    sum +=  int.Parse(num);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("ingrese otro numero");
                num = Console.ReadLine();
            }
            Console.WriteLine("la suma es: {0}", sum);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
}
