using System;

namespace Test_Enum
{
    class Program
    {
        enum orientation : short
        {
            North = 1,
            East = 2,
            South = 3,
            West = 4,
        }


        static void Main(string[] args)
        {
            orientation myOrientation = orientation.North;
            Console.WriteLine(myOrientation);

            byte directionByte = (byte)myOrientation;
            string directionString = Convert.ToString(myOrientation);

            Console.WriteLine("byte equivalent = {0}", directionByte);
            Console.WriteLine("string equivalent = {0}", directionString);
            Console.ReadKey();

        }
    }
}
