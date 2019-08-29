using System;

namespace Ch06Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are {0} arguments", args.Length);
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
