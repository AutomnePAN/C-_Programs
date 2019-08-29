using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Test_Events
{
    class Program
    {

        static int counter = 0;
        static string displayString ="In fact, I loved you once...";


        static void Main(string[] args)
        {
            Timer myTimer = new Timer(100);
            myTimer.Elapsed += new ElapsedEventHandler( WriteChar );
            myTimer.Start();
            Console.ReadKey();
        }

        static void WriteChar(object source, ElapsedEventArgs e)
        {
            counter += 13;
            Console.Write(displayString[counter % displayString.Length]);
        }
    }
}
