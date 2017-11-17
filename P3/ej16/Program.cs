using System;

namespace ej16
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ejercicio 16 */
            // redondea para arriba a partir del decimal igual o mayor a 5
            double r = 0.03;
            Console.WriteLine("{0:0.000} con 1 decimal vale: {0:0.0}", r);
            r += 0.02;
            Console.WriteLine("{0:0.000} con 1 decimal vale: {0:0.0}", r);
            r += 0.02;
            Console.WriteLine("{0:0.000} con 1 decimal vale: {0:0.0}", r);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 17 */
            double[,] matriz = new double[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            imprimirMatriz(matriz);
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 18 */
            imprimirMatriz(matriz, "{0,-8:00.00}");
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 19 */
            double [] m = getDiagonalPrincipal(matriz);
            if(m != null){for (int j = 0; j < m.Length; j++)
            {
                Console.Write("{0,-10}", m[j]);
            }Console.WriteLine();
            }else{Console.WriteLine("null");}
            double[,] matrizC = new double[,] { { 1, 2, 3}, { 5, 6, 7 }, { 9, 10, 11 } };
            m = getDiagonalPrincipal(matrizC);
            if (m != null){for (int j = 0; j < m.Length; j++)
            {
                Console.Write("{0,-10}", m[j]);
            }Console.WriteLine();
            }else { Console.WriteLine("null"); }
            m = getDiagonalSecundaria(matrizC);
            if (m != null){for (int j = 0; j < m.Length; j++)
            {
                Console.Write("{0,-10}", m[j]);
            }Console.WriteLine();
            }else { Console.WriteLine("null"); }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 20 */
            double[][] aa = getArregloDeArreglo(matriz);
            for (int i = 0; i < aa.Length; i++)
            {
                for (int j = 0; j < aa[i].Length; j++)
                {
                    Console.Write("{0,-10}", aa[i][j]);
                }
                Console.WriteLine();
            }
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* ejercicio 21 */
            Console.WriteLine("suma:");
            imprimirMatriz(suma(matriz,matriz));
            Console.WriteLine("resta:");
            imprimirMatriz(resta(matriz, matriz));
            Console.WriteLine("multiplicacion:");
            imprimirMatriz(multiplicacion(matrizC, matrizC));
            System.Console.WriteLine("Presione una tecla para continuar");
            System.Console.ReadKey(true);

            /* fin */
            System.Console.Write("bye..");
        }

        // metodo del ej17
        static void imprimirMatriz(double[,] matriz){
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("{0,-10}", matriz[i,j]);
                }
                Console.WriteLine();
            }
        }
        // metodo del ej18
        static void imprimirMatriz(double[,] matriz, string formatString){
            try
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        Console.Write(formatString, matriz[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // metodo del ej19
        static double[] getDiagonalPrincipal(double[,] matriz){
            if (matriz.GetLength(0) == matriz.GetLength(1))
            {
                double[] d = new double[matriz.GetLength(0)];
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    d[i] = matriz[i,i];
                }
                return d;
            }
            return null;
        }
        // metodo del ej19
        static double[] getDiagonalSecundaria(double[,] matriz){
            if (matriz.GetLength(0) == matriz.GetLength(1))
            {
                double[] d = new double[matriz.GetLength(0)];
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    d[i] = matriz[i, matriz.GetLength(0)-i-1];
                }
                return d;
            }
            return null;
        }
        // metodo del ej20
        static double[][] getArregloDeArreglo(double[,] matriz){
            double[][] aa = new double[matriz.GetLength(0)][];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                aa[i] = new double[matriz.GetLength(1)];
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    aa[i][j] = matriz[i, j];
                }
            }
            return aa;
        }
        // metodo del ej21
        static double[,] suma(double[,] A, double[,] B){
            if (A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1))
            {
                double[,] s = new double[A.GetLength(0),A.GetLength(1)];
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        s[i, j] = A[i, j] + B[i, j];
                    }
                }
                return s;
            }
            return null;
        }
        // metodo del ej21
        static double[,] resta(double[,] A, double[,] B){
            if (A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1))
            {
                double[,] s = new double[A.GetLength(0), A.GetLength(1)];
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        s[i, j] = A[i, j] - B[i, j];
                    }
                }
                return s;
            }
            return null;
        }
        // metodo del ej21
        static double[,] multiplicacion(double[,] A, double[,] B){
            Console.WriteLine("otro dia lo hago");
            if (A.GetLength(1) == B.GetLength(0))
            {
                double[,] s = new double[A.GetLength(0), A.GetLength(1)];
                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        s[i, j] = 0;
                    }
                }
                return s;
            }
            return null;
        }
    }
}
