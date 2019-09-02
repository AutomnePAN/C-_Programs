using System;

namespace HeapSort
{
    class Program
    {
        static public int parent(int i)
        {
            return (int) i / 2;
        }

        static public int  left_son(int i)
        {
            return 2 * i + 1;
        }

        static public int right_son(int i)
        {
            return 2 * i + 2;
        }

        static public void swap(double [] A, int i , int j)
        {
            if (i < 0 || i >= A.Length || j < 0 || j >= A.Length )
            {
                throw new IndexOutOfRangeException();
            }
            double temp = A[i];
            A[i] = A[j];
            A[j] = temp;
        }


        static public void MaxHeapify( double [] A, int  root, int size)
        {
            if ( root >= A.Length )
            {
                throw new IndexOutOfRangeException();
            }
            int largest = root;
            int left = left_son(root);
            int right = right_son(root);

            if (left < size && A[left] > A[largest])
            {
                largest = left;
            }
            if (right < size && A[right] > A[largest])
            {
                largest = right;
            }

            if (largest == root)
            {
                return;
            }
            else
            {
                swap(A, root, largest);
                MaxHeapify(A, largest, size);
            }
        }

        public static void BuildMaxHeap(double [] A)
        {
            int n = A.Length / 2;
            for(int i = n; i >= 0; i--)
            {
                MaxHeapify(A, i, A.Length);
            }
        }

        public static void HeapSort(double [] A)
        {
            BuildMaxHeap(A);
            int n = A.Length;
            for (int i = n-1; i >= 1 ; i--)
            {
                swap(A, i, 0);
                MaxHeapify(A, 0, i);
            }
        }

        public static void PrintArray(double [] A)
        {
            foreach(double i in A)
            {
                Console.Write(i + " ");

            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Array Original: ");
            Random ran = new Random();
            double[] test_A = new double [50];
            for(int i = 0; i < 50; i++)
            {
                test_A[i] = ran.Next(1, 100);
            }
            PrintArray(test_A);
            HeapSort(test_A);
            Console.WriteLine("After Sort");
            PrintArray(test_A);
        }
    }
}
