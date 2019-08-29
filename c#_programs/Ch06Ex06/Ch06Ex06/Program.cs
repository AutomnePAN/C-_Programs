using System;

namespace Ch06Ex06
{
    struct character
    {
        public int hp ;
        public int armer ;
        public character(int hp, int arm)
        {
            this.hp = hp;
            this.armer = arm;
        }
        public void ReportCondtion()
        {
            Console.WriteLine("The Character's health point is : " + this.hp);
            Console.WriteLine("The Character's armer point is : " + this.armer);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            character goblin = new character(100, 20);
            goblin.ReportCondtion();
            character knight;
            knight.hp = 100;
            knight.armer = 100;
            knight.ReportCondtion();
            Console.WriteLine(knight.GetType());
            Console.WriteLine(knight.GetHashCode());
            Console.WriteLine("Hello World!");
        }
    }
}
