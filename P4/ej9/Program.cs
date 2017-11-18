using System;

namespace ej9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 9 */
            Matriz A = new Matriz(2, 3);
            for (int i = 0; i < 6; i++) A.SetElemento(i / 3, i % 3, (i + 1) / 3.0);
            Console.WriteLine("Impresión de la matriz A");
            A.imprimir("0.000");
            double[,] aux = new double[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Matriz B = new Matriz(aux);
            Console.WriteLine("\nImpresión de la matriz B");
            B.imprimir();
            Console.WriteLine("\nAcceso al elemento B[1,2]={0}", B.GetElemento(1, 2));
            Console.Write("\nfila 1 de A: ");
            foreach (double d in A.GetFila(1)) Console.Write("{0:0.0} ", d);
            Console.Write("\n\nColumna 0 de B: ");
            foreach (double d in B.GetColumna(0)) Console.Write("{0} ", d);
            Console.Write("\n\nDiagonal principal de B: ");
            foreach (double d in B.GetDiagonalPrincipal()) Console.Write("{0} ", d);
            Console.Write("\n\nDiagonal secundaria de B: ");
            foreach (double d in B.GetDiagonalSecundaria()) Console.Write("{0} ", d);
            A.multiplicarPor(B);
            Console.WriteLine("\n\nA multiplicado por B");
            A.imprimir();
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }
    }
    
    class Matriz
    {
        double[,] M;
        public Matriz(int filas, int columnas){
            this.M = new double[filas, columnas];
        }
        public Matriz(double[,] matriz){
            this.M = matriz;
        }
        public void SetElemento(int fila, int columna, double elemento){
            this.M[fila, columna] = elemento;
        }
        public double GetElemento(int fila, int columna){
            return this.M[fila, columna];
        }
        public void imprimir(){
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0,-10} ", M[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void imprimir(string formatString){
                string s = "{0,-10:"+ formatString + "} ";
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                            Console.Write(s, M[i, j]);
                    }
                    Console.WriteLine();
                }
        }
        public double[] GetFila(int fila){
            double[] f = new double[M.GetLength(1)];
            for (int i = 0; i < M.GetLength(1); i++)
            {
                f[i] = M[fila, i];
            }
            return f;
        }
        public double[] GetColumna(int columna){
            double[] c = new double[M.GetLength(0)];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                c[i] = M[i, columna];
            }
            return c;
        }
        public double[] GetDiagonalPrincipal(){
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
        public double[] GetDiagonalSecundaria(){
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
        public double[][] getArregloDeArreglo(){
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
        public void sumarle(Matriz m){
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        M[i, j] = M[i, j] + m.GetElemento(i, j);
                    }
                }
        }
        public void restarle(Matriz m){
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i, j] = M[i, j] - m.GetElemento(i, j);
                }
            }
        }
        public void multiplicarPor(Matriz m){
            double[,] aux = new double[M.GetLength(0),M.GetLength(1)];
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    aux[i,j] = 0;
                    for (int k = 0; k < M.GetLength(1); k++)
                    {
                        aux[i,j] = aux[i, j] + M[i, k] * m.GetElemento(k, j);
                    }
                }
            }
            M = aux;
        }
    }
}
