using System;

namespace Ch06Ex01_TestFunction
{
    class Program
    {
        static int  MaxValue(int [] A)
        {
            int res = A[0];
            for (int  i = 0; i < A.Length; i++)
            {
                if (A[i] > res)
                {
                    res = A[i];
                }
            }
            return res;
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] test_A = new int[100];
            for (int i = 0; i < 100; i ++)
            {
                test_A[i] = rand.Next(0, i);
                Console.Write(test_A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(MaxValue(test_A));
        }
    }
}
