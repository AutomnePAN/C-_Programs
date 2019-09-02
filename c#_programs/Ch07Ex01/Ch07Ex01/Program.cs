using System;
using System.Diagnostics;

namespace Ch07Ex01
{
    class Program
    {
        static void Maxima(int [] array, out int [] index)
        {
            Debug.WriteLine("Maximum search started!", "Maxima ");
            int n = array.Length;
            int current_max = Int32.MinValue;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= current_max)
                {
                    current_max = array[i];
                }
            }
            Debug.WriteLine("The maximum value in the array is " + current_max, "Maxima ");
            for (int i = 0; i < n; i ++)
            {
                if ( array[i] == current_max )
                {
                    count += 1;
                }
            }
            Debug.WriteLine("There are " + count + " in the array which takes the maximum value");
            index = new int[count];
            count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == current_max)
                {
                    index[count] = i;
                    count += 1;
                }
            }
        }

        static void PrintArray(int[] A)
        {
            for(int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            int[] testA = new int[] { 1, 9, 2, 3, 4, 5, 6, 7, 8, 8, 8, 8, 8 };
            Debug.WriteLine("This Line is just for Debug");
            Console.WriteLine("Hello World!");
            Trace.WriteLine("This Line is just in trace");
            PrintArray(testA);
            Maxima(testA, out int[] index);
            PrintArray(index);
            Console.ReadKey();
        }
    }
}
