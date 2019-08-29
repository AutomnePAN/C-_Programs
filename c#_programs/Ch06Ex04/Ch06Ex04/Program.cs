using System;
using Ch06Ex04;
using Ch06Ex04.Parallel;


namespace Ch06Ex04
{
    using System.Collections;

    namespace Parallel
    {
        class Program_Parallel_1
        {
            static public void Write()
            {
                string myString = "This is in Parallel";
                Console.WriteLine(myString);
            }
        }
    }

    //using Parallel;
    
    class Program
    {
        static string myString = "Fuck you";
        
        static public void Write()
        {
            string myString = "This is in  class Program";
            Console.WriteLine(myString);
        }

        static void Main(string[] args)
        {
            
            Parallel.Program_Parallel_1.Write();
            string myString = "This is in Main";
            Console.WriteLine(myString);
            Console.WriteLine(Program.myString);
        }
    }
}
