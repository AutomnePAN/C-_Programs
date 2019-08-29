using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Definition_Of_Event
{
    public class Display
    {
        public void DisplayMessage(Connection source, MessageArrivedEventArgs e)
        {
            Console.WriteLine("Message arrived from : {0}", source.Name);
            Console.WriteLine("Message arrived: {0}", e.Message);
        }

    }
}
