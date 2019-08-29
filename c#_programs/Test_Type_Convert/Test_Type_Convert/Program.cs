using System;

namespace Test_Type_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            short A = 3000;
            short B = 3000;
            Console.WriteLine((A * B).GetType());
        }
    }
}
