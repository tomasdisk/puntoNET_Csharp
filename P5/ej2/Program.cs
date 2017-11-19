using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 2 */
            Persona p = new Persona() { Nombre = "pepe", DNI = "123456", FechaNacimiento = DateTime.Parse("01/06/2013"), Sexo = "ameba" };
            Console.WriteLine("{0} - DNI: {1} - Edad: {2} - Nacimiento: {3} - Sexo: {4}", p.Nombre, p.DNI, p.Edad, p.FechaNacimiento, p.Sexo);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(p[i]);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }

    class Persona
    {
        public string Nombre{
            set;
            get;
        }
        public string Sexo{
            set;
            get;
        }
        public string DNI{
            set;
            get;
        }
        public DateTime FechaNacimiento{
            get;
            set;
        }
        public int Edad{
            get{ return DateTime.Today.Year - FechaNacimiento.Year; }
        }
        public string this[int i]{
            get{
                if (i == 0) return this.Nombre;
                else if (i == 1) return this.Sexo;
                else if (i == 2) return this.DNI;
                else if (i == 3) return this.FechaNacimiento.ToString();
                else if (i == 4) return this.Edad.ToString();
                else return null;
            }
            set{
                if (i == 0) this.Nombre = value;
                else if (i == 1) this.Sexo = value;
                else if (i == 2) this.DNI = value;
                else this.FechaNacimiento = DateTime.Parse(value);
                
            }
        }
    }
}
