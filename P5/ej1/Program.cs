using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 1 */
            Matriz A = new Matriz(3, 3);
            for (int i = 0; i < 9; i++) A[i / 3, i % 3] = (i + 1);
            Console.WriteLine("Impresión de la matriz A");
            A.imprimir();
            Console.Write("\nAcceso al elemento A[1,0]={0}", A[1, 0]);
            Console.Write("\n\nDiagonal principal de A: ");
            foreach (double d in A.DiagonalPrincipal) Console.Write("{0} ", d);
            Console.Write("\n\nDiagonal secundaria de A: ");
            foreach (double d in A.DiagonalSecundaria) Console.Write("{0} ", d);
            System.Console.WriteLine();
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 4 */
            // el error es que en la clase el set se hace referencia a la propiedad 'Marca' y no al string privado 'marca' (por la 'M' mayuscula). haciendo que se llame infinitamente a la propiedad set.
            Auto a = new Auto();
            a.Marca = "Ford";
            Console.WriteLine(a.Marca);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 5 */
            // claseA => no se puede llamar a in miembre de intancia en un miembro estatico.
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 6 */
            System.Console.WriteLine(new Registro().IdRegistro);
            System.Console.WriteLine(new Registro().IdRegistro);
            System.Console.WriteLine(new Registro().IdRegistro);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }

    // clase del ej1
    class Matriz
    {
        double[,] M;
        public Matriz(int filas, int columnas)
        {
            this.M = new double[filas, columnas];
        }
        public Matriz(double[,] matriz)
        {
            this.M = matriz;
        }
        public double this[int f, int c]
        {
            get{ return this.M[f, c]; }
            set{ this.M[f, c] = value; }
        }
        public void imprimir()
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0,-10} ", M[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void imprimir(string formatString)
        {
            string s = "{0,-10:" + formatString + "} ";
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write(s, M[i, j]);
                }
                Console.WriteLine();
            }
        }
        public double[] GetFila(int fila)
        {
            double[] f = new double[M.GetLength(1)];
            for (int i = 0; i < M.GetLength(1); i++)
            {
                f[i] = M[fila, i];
            }
            return f;
        }
        public double[] GetColumna(int columna)
        {
            double[] c = new double[M.GetLength(0)];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                c[i] = M[i, columna];
            }
            return c;
        }
        public double[] DiagonalPrincipal {
            get{
                if (M.GetLength(0) == M.GetLength(1))
                {
                    double[] d = new double[M.GetLength(0)];
                    for (int i = 0; i < M.GetLength(0); i++)
                    {
                        d[i] = M[i, i];
                    }
                    return d;
                }
                return null;
            }
        }
        public double[] DiagonalSecundaria {
            get{
                if (M.GetLength(0) == M.GetLength(1))
                {
                    double[] d = new double[M.GetLength(0)];
                    for (int i = 0; i < M.GetLength(0); i++)
                    {
                        d[i] = M[i, M.GetLength(0) - i - 1];
                    }
                    return d;
                }
                return null;
            }
        }
        public double[][] getArregloDeArreglo()
        {
            double[][] aa = new double[M.GetLength(0)][];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                aa[i] = new double[M.GetLength(1)];
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    aa[i][j] = M[i, j];
                }
            }
            return aa;
        }
        public void sumarle(Matriz m)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = M[i, j] + m[i, j];
                }
            }
        }
        public void restarle(Matriz m)
        {
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = M[i, j] - m[i, j];
                }
            }
        }
        public void multiplicarPor(Matriz m)
        {
            double[,] aux = new double[M.GetLength(0), M.GetLength(1)];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    aux[i, j] = 0;
                    for (int k = 0; k < M.GetLength(1); k++)
                    {
                        aux[i, j] = aux[i, j] + M[i, k] * m[k, j];
                    }
                }
            }
            M = aux;
        }
    }
    // clase del ej4
    class Auto
    {
        private string marca;
        public string Marca
        {
            set
            {
                // Marca = value; // error
                marca = value;
            }
            get
            {
                return marca;
            }
        }
    }
    // clase del ej5
    class ClaseA
    {
        char c; static string st;
        void metodo1()
        {
            st = "string";
            c = 'A';
        }
        static void metodo2()
        {
            new ClaseA().c = 'a';
            st = "st2";
            // c = 'B'; //error porque el atributo 'c' no pertenece a ninguna intanca de la clase
        }
    }
    // clase del ej6
    class Registro
    {
        private static int count=0;
        private int idRegistro;
        public Registro(){
            idRegistro = count;
            count++;
        }
        public int IdRegistro{
            get{ return idRegistro; }
        }
    }
}
