using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 1 */
            // ni ganas de seguis con leyendo TABs
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 2 */
            // ni ganas de seguis con leyendo TABs
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 3 */
            new A().imprimir();
            new B().imprimir();
            new C().imprimir();
            new D().imprimir();
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 4 */
            A[] r = new A[4] {new C(), new D(), new D(), new C()};
            foreach (A a in r)
            {
                if (!(a is D) && a is C){a.imprimir();}
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 6 */
            // el proble es que la variable velocidad se define automatiacmente como private, por lo que hay que cambiarla a protectes para que la puedan usar las sub clases.
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 7 */
            Auto au = new Auto();
            check(au);
            au = new Taxi();
            check(au);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 8 */
            // es necesario agragarle un contructor a Taxii porque el contructor agregado por defecto no satisface al contructor de la super clase.
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
        // funcion del ej7
    static void check(Auto a)
    {
        if (a is Auto) Console.Write("Es un auto, ");
        if (a is Taxi) Console.WriteLine("es un taxi.");
        else Console.WriteLine("no es un taxi.");
    }
    }
    // clases el ej3
    class A
    {
        public virtual void imprimir(){Console.WriteLine("Clase A\n");}
    }
    class B:A
    {
        public override void imprimir() { Console.WriteLine("Clase B");base.imprimir(); }
    }
    class C : B
    {
        public override void imprimir() { Console.WriteLine("Clase C"); base.imprimir(); }
    }
    class D : C
    {
        public override void imprimir() { Console.WriteLine("Clase D"); base.imprimir(); }
    }
    // clases del ej6
    class Auto
    {
        protected double velocidad;
        public virtual void acelerar(){Console.WriteLine("Velocidad = {0}", velocidad += 10);}
    }
    class Taxi : Auto
    {
        public override void acelerar(){Console.WriteLine("Velocidad = {0}", velocidad += 5);}
    }
    // clases del ej8
    class Autoo
    {
        private string marca;
        public Autoo(string marca)
        {
            this.marca = marca;
        }
    }
    class Taxii : Autoo
    {
        public Taxii(string marca):base(marca)
        {
        }
    }
}
