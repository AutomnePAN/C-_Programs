using System;

namespace Test_Checked_Unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            byte destinationVar;
            short sourceVar = 281;
            destinationVar = unchecked((byte)sourceVar);
            Console.WriteLine("sourceVar val: {0}", sourceVar);
            Console.WriteLine("destinationVar val: {0}", destinationVar);
        }
    }
}
