using System;
using System.Collections;

namespace Insertion_Sort
{
    class Program
    {
        static void Insersion_Sort(double[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int j = i - 1;
                double key = A[i];
    

                while ( j >= 0 && A[j]  > key)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j+1] = key;
            }
             
        }

        static void MergeSort(double[] A, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                MergeSort(A, l, m);
                MergeSort(A, m + 1, r);
                Merge(A, l, m, r);
            }
        }

        static void Merge(double[] A, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m ;
            double[] A_l = new double[n1 + 1];
            double[] A_r = new double[n2 + 1];
            for(int i = 0; i < n1; i++)
            {
                A_l[i] = A[l + i];
            }

            for (int i = 0; i < n2; i++)
            {
                A_r[i] = A[m + i + 1];
            }
            A_l[n1] = UInt32.MaxValue;
            A_r[n2] = UInt32.MaxValue;
            int a = 0;
            int b = 0;
            for ( int k = l; k <= r; k++)
            {
                if (A_l[a] <= A_r[b])
                {
                    A[k] = A_l[a];
                    a++;
                }
                else
                {
                    A[k] = A_r[b];
                    b++;
                }
            }
         }

        static void PrintArray(double[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            Random random_num = new Random();
            double[] randomArray = new double[100];
            for (int i = 0; i < 100; i++)
            {
                randomArray[i] = random_num.Next(0,100);
            }
            Console.WriteLine("Before: ");
            PrintArray(randomArray);
            Console.WriteLine("\n After: ");
            MergeSort(randomArray,0,99);
            PrintArray(randomArray);
        }
    }
}
