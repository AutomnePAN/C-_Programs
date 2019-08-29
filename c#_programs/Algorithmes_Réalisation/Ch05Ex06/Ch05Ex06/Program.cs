using System;

namespace Ch05Ex06
{
    class Program
    {
        static void Read(int n)
        {
            return;
        }

        enum color:short
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Deepblue,
            Purple,
            Black,
            White
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            char[] resArray = new char[charArray.Length];
            for(int i = 0; i < charArray.Length; i++)
            {
                resArray[i] = charArray[charArray.Length - 1 - i];
            }
            string resStr = new string(resArray);
            return resStr;
        }

        static string Yes2No(string str)
        {
            return str.Replace("yes", "no");
            
        }


        static string Quotation(string str)
        {
            string res_str = str.Replace(" ", "\" \"");
            return "\"" + res_str + "\"";
        }
        static void Main(string[] args)
        {
            int valInt = Int32.MaxValue;
            short valShort = short.MaxValue;
            byte valByte = byte.MaxValue;
            bool valBoolean = true;
            //Console.WriteLine(valByte);
            Console.WriteLine("Input a phrase to test reverse: ");
            string test_str = Console.ReadLine();
            Console.WriteLine(ReverseString(test_str));
            Console.WriteLine(Yes2No(test_str));
            Console.WriteLine(Quotation(test_str));
            /*for(int i = 0; i < 19; i ++)
            {
                Console.WriteLine((color)i);
            }*/
            //Read(valBoolean);
            Console.ReadKey();
        }
    }
}
