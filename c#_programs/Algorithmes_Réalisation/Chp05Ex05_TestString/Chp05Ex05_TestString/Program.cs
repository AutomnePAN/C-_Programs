using System;

namespace Chp05Ex05_TestString
{
    class Program
    {

        static void Seperator(string str)
        {

        }

        static void CharArray(string str)
        {
            char[] charArray = str.ToCharArray();
            Console.WriteLine("The string contains {0} chars", charArray.Length);
            foreach(char ch in charArray)
            {
                Console.Write("{0} ", ch);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("Please input a phrase to be tested: ");
            string test_str = Console.ReadLine();
            Console.WriteLine(test_str.ToUpper());
            Console.WriteLine(test_str.ToLower());
            Console.WriteLine(test_str.Trim("Bitch".ToCharArray()));
            Console.WriteLine(test_str.PadLeft(20,'?'));
            Console.WriteLine(test_str.PadRight(20, '!'));
            CharArray(test_str);
            char separator = ' ';
            string[] stringSplited = test_str.Split(separator);
            foreach(string word in stringSplited)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
