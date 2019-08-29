using System;

namespace QuickSort
{
    class Program
    {
        static public void Swap(int [] A, int i, int j)
        {
            int temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }

        static public int  Partition(int [] A, int start, int end)
        {
            int n = A.Length;
            if ( start < 0 || end >= A.Length)
            {
                throw new IndexOutOfRangeException();
            }
            if(start == end)
            {
                return start;
            }
            Random ran = new Random();
            int pivot = ran.Next(start, end);
            Swap(A, pivot, end);
            int key = A[end];
            int i = start - 1;
            for(int j = start; j <= end - 1; j++)
            {
                if( A[j] <= key)
                {
                    i += 1;
                    Swap(A, i, j);
                }
            }
            Swap(A, i + 1, end);
            return i + 1;
        }


        static public void QuickSort(int [] A, int start, int end )
        {
            if (start < end)
            {
                int p = Partition(A, start, end);
                QuickSort(A, start, p - 1);
                QuickSort(A, p + 1, end);
                return;
            }
        }


        static public void PrintArray(int [] A)
        {
            foreach(int i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Random ran = new Random();
            int[] testA = new int[100];
            for (int i = 0; i < 100; i ++ )
            {
                testA[i] = ran.Next(0,100);
            }
            PrintArray(testA);
            QuickSort(testA,0,99);
            Console.WriteLine(" ");
            PrintArray(testA);
            Console.ReadKey();
            Console.WriteLine(Partition(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 }, 0, 7));
        }
    }
}
