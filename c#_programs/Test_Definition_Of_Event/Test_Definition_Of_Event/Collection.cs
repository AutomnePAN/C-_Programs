using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Linq;


namespace Test_Definition_Of_Event
{
    public delegate void MessageHandler(Connection source, MessageArrivedEventArgs e);

    public class Connection
    {
        public string Name;
        public event MessageHandler MessageArrived;
        private Timer polltimer;
        public Connection()
        {
            polltimer = new Timer(100);
            polltimer.Elapsed += new ElapsedEventHandler(CheckForMessage);
            Name = "Nothing";
        }

        public void Connect()
        {
            polltimer.Start();
        }

        public void Disconnect()
        {
            polltimer.Stop();
        }

        private static Random random = new Random();

        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Checking for new messages.");
            if ((random.Next(9) == 0) && (MessageArrived != null))
            {
                MessageArrived(this, new MessageArrivedEventArgs("Hello Mum!"));
            }
        }
    }
}
