using System;

namespace ej1
{
    delegate void TrabajandoEventHandler();
    delegate void tipoDelegado();
    delegate int tipoDelegadoInt();
    delegate void TicEventHandler(object sender, DateTimeEventArgs e);
    class Program
    {
        private static TrabajandoEventHandler delegado1, delegado2;
        static int cont = 0;
        static Clock reloj = new Clock();
        static void Main(string[] args)
        {
            /* ejercicio 1, 2, 3, 4, 5, 6 y 7 */
            {
                Trabajador o = new Trabajador();
                o.Trabajando = new TrabajandoEventHandler(F);
                o.Trabajando += new TrabajandoEventHandler(F);
                o.Trabajando += new TrabajandoEventHandler(G);
                o.Trabajando += new TrabajandoEventHandler(G);
                //o.Trabajando = new TrabajandoEventHandler(G);
                o.Trabajando -= new TrabajandoEventHandler(F);
                o.Trabajar();
                Console.WriteLine("---------------");
                o.Trabajando -= new TrabajandoEventHandler(F);
                o.Trabajando -= new TrabajandoEventHandler(F);
                o.Trabajando -= new TrabajandoEventHandler(F);
                o.Trabajar();
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 8 */
            {
                delegado1 += new TrabajandoEventHandler(F);
                delegado1 += new TrabajandoEventHandler(G);
                delegado2 += new TrabajandoEventHandler(F);
                delegado2 += new TrabajandoEventHandler(G);
                Trabajador o = new Trabajador();
                o.Trabajando = delegado1 + delegado2;
                o.Trabajar();
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 9 */
            {
                delegado1 -= delegado1;
                delegado2 -= delegado2;
                Console.WriteLine("--------------a");
                delegado1 += new TrabajandoEventHandler(A);
                delegado1 += new TrabajandoEventHandler(B);
                delegado1 += new TrabajandoEventHandler(C);
                delegado2 += new TrabajandoEventHandler(B);
                delegado2 += new TrabajandoEventHandler(C);
                delegado2 += new TrabajandoEventHandler(D);
                Trabajador o = new Trabajador();
                o.Trabajando = delegado1 - delegado2;
                o.Trabajar();
            }{
                delegado1 -= delegado1;
                delegado2 -= delegado2;
                Console.WriteLine("--------------b");
                delegado1 += new TrabajandoEventHandler(A);
                delegado1 += new TrabajandoEventHandler(B);
                delegado1 += new TrabajandoEventHandler(C);
                delegado1 += new TrabajandoEventHandler(D);
                delegado2 += new TrabajandoEventHandler(A);
                delegado2 += new TrabajandoEventHandler(C);
                Trabajador o = new Trabajador();
                o.Trabajando = delegado1 - delegado2;
                o.Trabajar();
            }{
                delegado1 -= delegado1;
                delegado2 -= delegado2;
                Console.WriteLine("--------------c");
                delegado1 += new TrabajandoEventHandler(A);
                delegado1 += new TrabajandoEventHandler(B);
                delegado1 += new TrabajandoEventHandler(C);
                delegado1 += new TrabajandoEventHandler(D);
                delegado2 += new TrabajandoEventHandler(A);
                delegado2 += new TrabajandoEventHandler(B);
                delegado2 += new TrabajandoEventHandler(C);
                Trabajador o = new Trabajador();
                o.Trabajando = delegado1 - delegado2;
                o.Trabajar();
            }{
                delegado1 -= delegado1;
                delegado2 -= delegado2;
                Console.WriteLine("--------------a");
                delegado1 += new TrabajandoEventHandler(A);
                delegado1 += new TrabajandoEventHandler(B);
                delegado1 += new TrabajandoEventHandler(C);
                delegado1 += new TrabajandoEventHandler(D);
                delegado2 += new TrabajandoEventHandler(B);
                delegado2 += new TrabajandoEventHandler(C);
                Trabajador o = new Trabajador();
                o.Trabajando = delegado1 - delegado2;
                o.Trabajar();
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 10 */
            {
                tipoDelegado delegado;
                Objeto o = new Objeto();
                delegado = o.getDelegado("999");
                delegado();
                delegado = o.getDelegado("123");
                delegado();
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 11 y 12 */
            {
                // se imprime y asigna en 'i' el valor que devuelve el ultimo de los metodos ejecutados.
                tipoDelegadoInt delegado;
                delegado = new tipoDelegadoInt(devuelveUno);
                delegado += new tipoDelegadoInt(devuelveDos);
                int i = delegado();
                Console.WriteLine(i);
                Console.WriteLine("---------------");
                System.Delegate[] listaDelegados = delegado.GetInvocationList();
                foreach (tipoDelegadoInt del in listaDelegados)
                {
                    i = del();
                    Console.WriteLine(i);
                }
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 13 y 14 */
            {
                reloj.Tic = new TicEventHandler(Tic);
                reloj.run();
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
        // metodo del ej1
        private static void F()
        {
            Console.WriteLine("El trabajo se ha iniciado");
        }
        // metodo del ej3
        private static void G()
        {
            Console.WriteLine("Ejecutando el método G");
        }
        // metodos del ej9
        private static void A() { Console.WriteLine("A"); }
        private static void B() { Console.WriteLine("B"); }
        private static void C() { Console.WriteLine("C"); }
        private static void D() { Console.WriteLine("D"); }
        // metodos del ej11
        static int devuelveUno()
        {
            Console.WriteLine("Ejecutando devuelveUno()");
            return 1;
        }
        static int devuelveDos()
        {
            Console.WriteLine("Ejecutando devuelveDos()");
            return 2;
        }
        // metodo del ej13
        private static void Tic(object sender, DateTimeEventArgs e)
        {
            Console.WriteLine(e.Datetime);
            cont++;
            if (cont == 10) reloj.Detener();
        }
    }
    // clase del ej1
    class Trabajador
    {
        public TrabajandoEventHandler Trabajando;
        public void Trabajar()
        {
            if (Trabajando != null) Trabajando();
            //realiza algún trabajo
            Console.WriteLine("Trabajo concluido");
        }
    }
    // clase del ej10
    class Objeto
    {
        private void metodoPrivado()
        {
            Console.WriteLine("método privado del objeto");
        }
        public void metodoPublico()
        {
            Console.WriteLine("método público del objeto");
        }
        public tipoDelegado getDelegado(string clave)
        {
            if (clave == "123") return new tipoDelegado(metodoPrivado);
            else return new tipoDelegado(metodoPublico);
        }
    }
    // clase del ej13
    class Clock
    {
        private bool detener;
        public TicEventHandler Tic;
        public void run()
        {
            DateTime hora = DateTime.Parse("1/1/2000"), horaAux = DateTime.Now;
            detener = false;
            while (!detener)
            {
                if (hora.Second != horaAux.Second)
                {
                    hora = horaAux;
                    if (Tic != null) Tic(this, new DateTimeEventArgs{Datetime=hora});
                }
                horaAux = DateTime.Now;
            }
        }
        public void Detener()
        {
            detener = true;
        }
    }
    // clase del ej14
    class DateTimeEventArgs
    {
        public DateTime Datetime{get;set;}
    }
}
