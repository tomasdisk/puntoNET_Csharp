using System;

namespace ej_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 6 */
            Console.WriteLine("Ingrese su nombre:");
            String name = Console.ReadLine();
            if (name != "" && name != " ")
            {
                Console.WriteLine("Hola " + name + "!");
            }else
            {
                Console.WriteLine("Hola Mundo!");
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 7 */
            /* utilizando if.. else if.. */
            Console.WriteLine("Ingrese su nombre:");
            name = Console.ReadLine();
            if (name != "" && name != " ")
            {   
                if (name == "Juan")
                {
                    Console.WriteLine("¡Hola amigo! Me alegro de verte!");
                }else if (name == "Maria")
                {
                    Console.WriteLine("Buen día señora!");
                }else if (name == "Alberto")
                {
                    Console.WriteLine("Hola Alberto, que tenga usted un buen día!");
                }else
                {
                    Console.WriteLine("Buen día " + name + "!");
                }
            }
            else
            {
                Console.WriteLine("¡Buen día mundo!");
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* utilizando switch */
            Console.WriteLine("Ingrese su nombre:");
            name = Console.ReadLine();
            switch (name)
            {
                case "":
                case " ":
                    Console.WriteLine("¡Buen día mundo!");
                    break;
                case "Juan":
                    Console.WriteLine("¡Hola amigo! Me alegro de verte!");
                    break;
                case "Maria":
                    Console.WriteLine("Buen día señora!");
                    break;
                case "Alberto":
                    Console.WriteLine("Hola Alberto, que tenga usted un buen día!");
                    break;
                default:
                    Console.WriteLine("Buen día " + name + "!");
                    break;
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 8 */
            name = " ";
            while (name != "")
            {
            Console.WriteLine("Ingrese un texto:");
            name = Console.ReadLine();
            Console.WriteLine("La cantidad de caracteres ingresados es: " + name.Length);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
}
