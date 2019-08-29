using System;

namespace Ch06Ex03
{
    class Program
    {
        static public void Swap_Val(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("In the function Swap Value: ");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
        }

        static public void Swap_Ref(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("In the function Swap refrence: ");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
        }


        static void Main(string[] args)
        {
            int a = 10, b = 9;
            Console.WriteLine("Before the function Swap Value: ");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Swap_Val(a, b);
            Console.WriteLine("After the function Swap Value: ");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.WriteLine();

            Console.WriteLine("Before the function Swap Reference: ");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Swap_Ref(ref a, ref b);
            Console.WriteLine("After the function Swap Reference: ");
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
        }
    }
}
