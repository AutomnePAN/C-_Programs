using System;

namespace Ch07Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            A[0] = 10;
            while(true)
            {
                try
                {
                    Console.WriteLine("Please input the index fo number you want to know :");
                    int index = Convert.ToInt32(Console.ReadLine());
                    try
                    {
                        Console.WriteLine("The " + (index + 1) + " number is " + A[index]);
                    }
                    catch (IndexOutOfRangeException) when (A[0] == 0)
                    {
                        Console.WriteLine("The index is out of range, the first number is null");
                        Console.ReadKey();
                        break;
                    }
                    finally
                    {
                        Console.WriteLine("Now input another number please!");
                    }
                }
                catch(IndexOutOfRangeException) when(A[0] != 0)
                {
                    Console.WriteLine("The index is out of range, while the first item is not 0");
                    break;
                }
                finally
                {
                    Console.WriteLine("Now input another number please!");
                }
            }
        }
    }
}
