using System;
using System.Collections.Generic;
using System.Text;

namespace Test_List_T
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
