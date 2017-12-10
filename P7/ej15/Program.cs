using System;

namespace ej15
{
    delegate void LeyoEventHandler(object sender, EventArgs e);
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 15 */
            {
                Palabras pal = new Palabras();
                pal.contar();
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
    class Palabras
    {
        private int cantPalabras = 0;
        public void contar()
        {
            Lector miLector = new Lector();
            miLector.Leyo = new LeyoEventHandler(unaMas);
            miLector.leer();
            Console.WriteLine("Cantidad de palabras leídas: {0}", cantPalabras);
        }
        private void unaMas(object sender, EventArgs e)
        {
            cantPalabras++;
        }
    }
    class Lector
    {
        public LeyoEventHandler Leyo;
        public void leer()
        {
            Console.WriteLine("Ingrese una palabra por línea");
            string st = Console.ReadLine();
            while (st != "")
            {
                if (Leyo != null) Leyo(this, new EventArgs());
                st = Console.ReadLine();
            }
        }
    }
}
