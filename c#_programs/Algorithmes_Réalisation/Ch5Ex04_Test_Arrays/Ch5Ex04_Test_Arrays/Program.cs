using System;

namespace Ch5Ex04_Test_Arrays
{
    class Program
    {
        static void PrintArray(Object [] A)
        {
            foreach(Object item in A)
            {
                Console.Write(item.ToString() + " ,");
            }
        }

        static void PrintMatrix(double [,] M)
        {
            foreach(double item in M)
            {
                Console.Write(item + " ,");
            }
            Console.Write("\n");
        }

        static void PrintDoubleArray(double [][] doubleArray)
        {
            foreach(double[] array in doubleArray)
            {

                //Console.Write(array);
                foreach(double num in array)
                {
                    Console.Write(num + ", ");
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            double[,] matrix = new double[10, 10];
            double[][] jaggedArray;
            jaggedArray = new double[3][] { new double[2] { 1, 2 }, new double[] { 1,2,3,4,5,6}, new double[] { 9,8,7,6,5} };
            for(int i = 0; i< 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    matrix[i, j] = i * j;
                }
            }
            string[] chevaux = { "Ovan", "Saxo", "Belle", "Uruquin", "Pok" };
            PrintArray(chevaux);
            PrintMatrix(matrix);
            PrintDoubleArray(jaggedArray
                );
            Console.ReadKey();
        }
    }
}
