using System;

namespace Ch06Ex02
{
    class Program
    {
        static int Sum (params int [] value)
        {
            int res = 0;
            Console.WriteLine("The length of arguments is : " + value.Length);
            for(int i = 0; i < value.Length; i++)
            {
                res += value[i];
            }
            return res;
        }

        static string GetWord(string s, params int[] n)
        {
            int index = 0;
            if (n.Length > 0)
            {
                index = n[0];
            }
            if (n.Length >= 2)
            {
                index = Sum(n);
            }
            char[] separator = new char[] { ' ' };
            string[] words = s.Split(separator);
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("The {0} word is : " + words[index], index);
            return words[index];
        }

        static void Main(string[] args)
        {
            int s = Sum(new int[] { 1,2,3,4,5,6,7,8,9});
            Console.WriteLine("The sum of arguments is : " + s);
            Console.WriteLine("Please input a phrase: ");
            string testStr = Console.ReadLine();
            GetWord(testStr);
            GetWord(testStr,1);
            GetWord(testStr, 2);
            GetWord(testStr, 1, 2, 3, 4);
            Console.ReadKey();
        }
    }
}
