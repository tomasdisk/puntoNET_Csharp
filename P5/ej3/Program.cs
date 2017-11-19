using System;
using System.Collections;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 3 */
            ListaDePersonas l = new ListaDePersonas();
            l.Agregar(new Persona() { Nombre = "Juan", DNI = "20213213" });
            l.Agregar(new Persona() { DNI = "22123123", Nombre = "María" });
            l.Agregar(new Persona() { Nombre = "José", DNI = "40111222" });
            l.Agregar(new Persona() { DNI = "22177123", Nombre = "Pepe" });
            Console.WriteLine("{0} DNI: {1}", l[22123123].Nombre, l[22123123].DNI);
            foreach (string s in l['J'])
            {
                Console.WriteLine(s);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
    class Persona
    {
        public string Nombre
        {
            set;
            get;
        }
        public string Sexo
        {
            set;
            get;
        }
        public string DNI
        {
            set;
            get;
        }
        public DateTime FechaNacimiento
        {
            get;
            set;
        }
        public int Edad
        {
            get { return DateTime.Today.Year - FechaNacimiento.Year; }
        }
        public string this[int i]
        {
            get
            {
                if (i == 0) return this.Nombre;
                else if (i == 1) return this.Sexo;
                else if (i == 2) return this.DNI;
                else if (i == 3) return this.FechaNacimiento.ToString();
                else if (i == 4) return this.Edad.ToString();
                else return null;
            }
            set
            {
                if (i == 0) this.Nombre = value;
                else if (i == 1) this.Sexo = value;
                else if (i == 2) this.DNI = value;
                else this.FechaNacimiento = DateTime.Parse(value);

            }
        }
    }
    class ListaDePersonas
    {
        private ArrayList lista = new ArrayList();
        public void Agregar(Persona p)
        {
            lista.Add(p);
        }
        public Persona this[int dni]{
            get{
                foreach (Persona p in lista)
                {
                    if (p.DNI == dni.ToString()) return p;
                }
                return null;
            }
        }
        public string[] this[char c]{
            get{
                Queue q = new Queue();
                foreach (Persona p in lista)
                {
                    if (p.Nombre[0] == c) q.Enqueue(p.Nombre);
                }
                int n = q.Count;
                string[] s = new string[n];
                for (int i = 0; i < n; i++)
                {
                    s[i] = (string)q.Dequeue();
                }
                return s;
            }
        }
    }
}
