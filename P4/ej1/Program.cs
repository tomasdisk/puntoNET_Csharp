using System;
using System.Collections;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 1 */
            Hora h = new Hora(23, 30, 15);
            h.imprimir();
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 2 */
            Hora h1 = new Hora(23, 30, 15);
            Hora h2 = new Hora(14.633);
            h1.imprimir();
            h2.imprimir();
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 3 */
            // op1 con ArrayList de personas
            ArrayList p = new ArrayList();
            Console.WriteLine("ingrese el primer dato:");
            string dato = Console.ReadLine();
            while (dato != "")
            {   
                string[] aux = dato.Split('\t');
                p.Add(new Persona(aux[0], int.Parse(aux[1]), aux[2]));
                Console.WriteLine("ingrese el dato numero {0}:", p.Count + 1);
                dato = Console.ReadLine();
            }
            for (int i = 0; i < p.Count; i++)
            {
                Persona per = (Persona)p[i];
                Console.WriteLine("{0}) {1,-20} ({2})\t\t{3}", i+1, per.Nombre, per.Edad, per.DNI);
            }
            // op2 con arreglo de personas
            Console.WriteLine("ingrese la cantidad de datos:");
            int c = int.Parse(Console.ReadLine());
            Persona[] p1 = new Persona[c];
            string dato1 = " ";
            int j = 0;
            while (dato1 != "" && j < c)
            {
                Console.WriteLine("ingrese el dato numero {0}:", j+1);
                dato1 = Console.ReadLine();
                string[] aux = dato1.Split('\t');
                p1[j]= new Persona(aux[0], int.Parse(aux[1]), aux[2]);
                j++;
            }
            for (int i = 0; i < p1.Length; i++)
            {
                p1[i].imprimir(i);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 4 */
            Console.WriteLine("ya se resolvio en el ej3");
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 5 */
            foreach (Persona pe in p1)
            {
                if (pe.Nombre[0] == 'a' || pe.Nombre[0] == 'e' || pe.Nombre[0] == 'i' || pe.Nombre[0] == 'o' ||  pe.Nombre[0] == 'u')
                {
                    pe.cumple();
                }
            }
            for (int i = 0; i < p1.Length; i++)
            {
                p1[i].imprimir(i);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 6 */
            Console.WriteLine("me harte de modifcar el mismo programa, otro dia lo hago");
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 7 */
            for (int i = 1; i < p1.Length; i++)
            {
                Console.WriteLine(p1[0].esMayorQue(p1[i]));
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }

        // clase del ej1 y ej2
        class Hora
        {
            int hora;
            int min;
            int seg;
            public Hora(int hora, int min, int seg)
            {
                this.hora = hora;
                this.min = min;
                this.seg = seg;
            }
            public Hora(double hora)
            {
                
                this.hora = (int)hora/1;
                int aux = ((int)(hora * 100)%100)*60;
                this.min = aux/100;
                aux = (aux%100)*60;
                this.seg = aux/100;
            }
            public void imprimir()
            {
                Console.WriteLine("{0} HORAS, {1} MINUDOTOS Y {2} SEGUNDOS", hora, min, seg);
            }
        }
        // clase del ej3
        class Persona
        {
            public String Nombre;
            public int Edad;
            public String DNI;
            public Persona(String Nombre, int Edad, String DNI)
            {
                this.Nombre = Nombre;
                this.Edad = Edad;
                this.DNI = DNI;
            }
            public void imprimir(int i = 0)
            {
                Console.WriteLine("{0}) {1,-20} ({2})\t\t{3}", i, this.Nombre, this.Edad, this.DNI);
            }
            public void cumple()
            {
                this.Edad++;
            }
            public bool esMayorQue(Persona p)
            {
                if (this.Edad > p.Edad)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
        }
    }
}
