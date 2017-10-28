using System;
using System.Text;
using System.Collections;

namespace ej_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 8 */
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Hola {0}!",args[i]);
            }
            foreach (string a in args)
            {
                Console.WriteLine("Hola {0}!",a);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 9 */
            foreach (string a in args)
            {
                bool ok = true;
                for (int j = 0; j < a.Length/2; j++)
                {
                    if(a[j]!=a[a.Length-1-j]){
                        ok = false;
                        break;
                    }
                }
                if (ok)
                {
                    Console.WriteLine("{0} es palindrome.",a);
                }else
                {
                    Console.WriteLine("{0} NO es palindrome.",a);
                }
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 10 */
            // caso 1 sin stringBuilder
            {
                string st = "";
                foreach (string a in args)
                {
                    st += " "+a;
                    Console.WriteLine("{0}",st);
                }
            }
            // caso 2 con stringBuilder
            {
                StringBuilder st = new StringBuilder("");
                foreach (string a in args)
                {
                    st.Append(" "+a);
                    Console.WriteLine("{0}",st);
                }
            }        
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 11 */
            // caso 1 sin stringBuilder
            long aux = DateTime.Now.Ticks;;
            {
                string st = "";
                foreach (string a in args)
                {
                    st += " "+a;
                }
            }
            long c1 = DateTime.Now.Ticks - aux;
            // caso 2 con stringBuilder
            aux = DateTime.Now.Ticks;
            {
                StringBuilder st = new StringBuilder("");
                foreach (string a in args)
                {
                    st.Append(" "+a);
                }
            }
            long c2 = DateTime.Now.Ticks - aux;
            System.Console.WriteLine("Con string => {0} Ticks y con StringBuilder => {1} Ticks.",c1,c2);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 12 */
            // se prueban los sigentes 3 tipos de arreglos 'a0', 'a1' y 'a2'.
            int[] a0 = new int[200];
            Array a1 = Array.CreateInstance(typeof(int), 200);
            ArrayList a2 = new ArrayList(200);
            for (int i = 0; i < 200; i++)
            {
                a0[i] = i;
                a1.SetValue(i,i);
                a2.Add(i);
            }

            // binarySearch
            aux = DateTime.Now.Ticks;
            int i0 = Array.BinarySearch(a0, 77);
            long t0 = DateTime.Now.Ticks - aux;

            aux = DateTime.Now.Ticks;
            int i1 = Array.BinarySearch(a1, 77);
            long t1 = DateTime.Now.Ticks - aux;

            aux = DateTime.Now.Ticks;
            int i2 = a2.BinarySearch(77);
            long t2 = DateTime.Now.Ticks - aux;

            System.Console.WriteLine("Resultados => {0}, {1}, {2}", i0, i1 , i2);
            System.Console.WriteLine("BinarySearch tiempos => {0}, {1}, {2}", t0, t1, t2);
            // busqueda secuencial
            aux = DateTime.Now.Ticks;
            for (i0 = 0; i0 < a0.Length; i0++)
                if (a0[i0]==77)
                    break;
            t0 = DateTime.Now.Ticks - aux;

            for (i1 = 0; i1 < a1.Length; i1++)
                if (a1.GetValue(i1).Equals(77))
                    break;
            t1 = DateTime.Now.Ticks - aux;

            for (i2 = 0; i2 < a2.Count; i2++)
                if (a2[i2].Equals(77))
                    break;
            t2 = DateTime.Now.Ticks - aux;

            System.Console.WriteLine("Resultados => {0}, {1}, {2}", i0, i1, i2);
            System.Console.WriteLine("Busqueda secuencial tiempos => {0}, {1}, {2}", t0, t1, t2);            
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 13 */
            ArrayList names = new ArrayList();
            ArrayList DNI1 = new ArrayList();
            ArrayList DNI2 = new ArrayList();
            ArrayList DNI3 = new ArrayList();
            Console.WriteLine("ingrese el primer dato:");
            string dato = Console.ReadLine();
            while (dato != "")
            {
                // op1 recocciendo string
                for (int i = 0; i < dato.Length; i++){
                    if (dato[i] == '\t'){
                        DNI1.Add(int.Parse(dato.Substring(dato.IndexOf('\t')+1)));
                        break;}}
                // op2 indexOf
                DNI2.Add(int.Parse(dato.Substring(dato.IndexOf('\t')+1)));
                // op3 split
                DNI3.Add(int.Parse(dato.Split('\t')[1]));

                names.Add(dato);
                Console.WriteLine("ingrese el dato numero {0}:", names.Count+1);
                dato = Console.ReadLine();
            }
            // ordenamiento
            DNI1.Sort();
            DNI2.Sort();
            DNI3.Sort();
            foreach (string s in names)
                Console.WriteLine(s);
            Console.WriteLine("---");
            foreach (int s in DNI1)
                Console.WriteLine(s);
            Console.WriteLine("---");
            foreach (int s in DNI2)
                Console.WriteLine(s);
            Console.WriteLine("---");
            foreach (int s in DNI3)
                Console.WriteLine(s);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
}
