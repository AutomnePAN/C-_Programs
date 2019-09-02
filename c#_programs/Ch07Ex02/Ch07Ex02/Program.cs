using System;
using System.Diagnostics;

namespace Ch07Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int product = 1;
            Console.WriteLine("Now test the out put!");
            for(int i = 0; i < 20;i++)
            {
                Console.WriteLine("sum: {0}", sum);
                Console.WriteLine("Fact:{0}", product);
                sum += i;
                product *= i;
                //Trace.Assert(i < 10, "i is larger than 10");
            }
            Console.WriteLine("Everthing goes right");
            Console.WriteLine("Hello world!");
        }
    }
}
