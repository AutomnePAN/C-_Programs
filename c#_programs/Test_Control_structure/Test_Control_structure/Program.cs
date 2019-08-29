using System;

namespace Test_Control_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myInteger = 15;
            //String myString  =  myInteger < 10 ? "Hello World!" : "Fuck World!";
            //Console.WriteLine(myString);

            /*
             * Test GoTo

             * start:
                int myInteger = 5;
                goto addVal;
            writeResult:
                Console.WriteLine("myInteger = {0}", myInteger);
                goto start;
            addVal:
                myInteger += 10;
                goto writeResult; */

            /* Test If
             * 
            string comparison;
            Console.WriteLine("Enter a number:");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(Console.ReadLine());

            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";
            }
            Console.WriteLine("The first number is {0} the second number.",
            comparison);
            Console.ReadKey(); */

            /*const string myName = "karli";
            const string sexyName = "angelina";
            const string sillyName = "ploppy";
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case sexyName:
                    Console.WriteLine("My, what a sexy name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That抯 a very silly name.");
                    break;
                default:
                    Console.WriteLine("I don't know you!");
                    break;
            }
            Console.WriteLine("Hello {0}!", name);
            Console.ReadKey();*/

            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            while(balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",
            totalYears, totalYears == 1 ? "" : "s", balance);
            Console.ReadKey();
        }
    }
}
