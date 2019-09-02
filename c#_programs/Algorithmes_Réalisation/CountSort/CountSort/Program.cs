using System;

namespace CountSort
{
    class Program
    {
        static void CountSort(int [] A, out int [] B, int k)
        {
            int n = A.Length;
            B = new int[n];
            int[] C = new int[k];
            for (int i = 0 ; i < n ;   i++)
            {
                C[A[i]] += 1;
            }
            PrintArray(C);
            for (int i = 1; i < k; i++)
            {
                C[i] = C[i] + C[i - 1];
            }
            PrintArray(C);
            for(int i = 0; i < n;  i++)
            {
                B[C[A[i]] - 1] = A[i];
                C[A[i]] -= 1;
            }
        }

        static void PrintArray(int[] A)
        {
            foreach(int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" \n");
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] test_A = new int[100];
            for(int i = 0; i < 100; i++)
            {
                test_A[i] = rand.Next(0, 20);
            }
            int[] B;
            PrintArray(test_A);
            CountSort(test_A, out B, 20);
            PrintArray(B);
            Console.ReadKey();
        }
    }
}
