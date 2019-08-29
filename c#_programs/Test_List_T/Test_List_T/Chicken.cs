using System;
using System.Collections.Generic;
using System.Text;

namespace Test_List_T
{
    public class Chicken : Animal
    {
        public void LayEgg()
        {
            Console.WriteLine("{0} has laid an egg.", name);
        }
        public Chicken(string newName) : base(newName)
        {
        }
    }
}
