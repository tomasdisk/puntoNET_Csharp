namespace ej_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            /* ejercicio 4 */
            /* por cada iteracion del for el proce4sos se duerme 500ms */
            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine("Hola Mundo!\a");
                System.Threading.Thread.Sleep(500);
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* se ejecutan todas las iteraciones de corrido, po lo que se escucha un solo beep '\a' */
            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine("Hola Mundo!\a");
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 5 */
            /* usar '\d' implica un error de compilacion porque no reconoce la secuencia, para usar el caracter '\' hay que utilizar '\\' */
            System.Console.WriteLine("c:\\documento.txt");
        
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
}
