using System;

namespace JustTest
{
    class Program
    {
        public enum direction: int
        {
            North = 1,
            South = 2,
            East = 3,
            West = 4,
        }
        
        public struct postion
        {
            public direction dir;
            public double dis;
        }

        static void Main(string[] args)
        {
            postion Home;
  
            for(int i = 0; i < 5; i++)
            {
                int direction_int = -1;
                do
                {
                    Console.WriteLine("1:North, 2:South, 3:East, 4:West");
                    Console.Write("Please Input a Number represent the direction:");
                    direction_int = Convert.ToInt32(Console.ReadLine());
                }
                while (direction_int < 1 || direction_int > 4);
                Home.dir = (direction)direction_int;
                Console.Write("How far it is: ");
                Home.dis = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Your home is in the direction: " + Home.dir + " it's " + Home.dis+ " km far.");
            }   

        }
    }
}
