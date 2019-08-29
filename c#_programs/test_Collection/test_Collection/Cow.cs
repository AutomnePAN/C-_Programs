using System;
using System.Collections.Generic;
using System.Text;

namespace test_Collection
{
    public class Cow : Animal
    {
        public Cow(string newName) : base(newName)
        {
            
        }

        public void Milk()
        {
            Console.WriteLine("{0} has been milked.", name);
        }
        
    }
}
