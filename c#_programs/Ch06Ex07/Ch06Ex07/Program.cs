using System;

namespace Ch06Ex07
{
    class Program
    {
        public delegate double Ariths(double n1, double n2);

        static double plus(double num1, double num2)
        {
            return num1 + num2;
        }

        static double minus(double num1, double num2)
        {
            return num1 - num2;
        }

        static double multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        static double divide(double num1, double num2)
        {
            return num1 / num2;
        }
        static public void WhatShouldIDo(Ariths A)
        {
            for(int i = 0; i < 1000; i ++)
            {
                Console.WriteLine(A(i, 1000 - i));
            }
        }

        static void Main(string[] args)
        {
            Ariths A;
            Console.WriteLine("Please input two numbers for calculate");
            string input = Console.ReadLine();
            string[] inputsArray = input.Split(" ");
            double num1 = Double.Parse(inputsArray[0]);
            double num2 = Double.Parse(inputsArray[1]);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine("Which operation do you want to apply ? ");
            string Op = "";
            do
            {
                Console.WriteLine("\"P\" for Plus ");
                Console.WriteLine("\"S\" for Minus ");
                Console.WriteLine("\"M\" for Multiply ");
                Console.WriteLine("\"D\" for Divide ");
                Op = Console.ReadLine().ToUpper();
            }
            while (Op != "M" && Op != "P" && Op != "S" && Op != "D");
            switch(Op)
            {
                case "P":
                    A = plus;
                    break;
                case "M":
                    A = multiply;
                    break;
                case "S":
                    A = minus;
                    break;
                case "D":
                    A = divide;
                    break;
                default:
                    throw new Exception();
            }
            WhatShouldIDo(A);

        }
    }
}
