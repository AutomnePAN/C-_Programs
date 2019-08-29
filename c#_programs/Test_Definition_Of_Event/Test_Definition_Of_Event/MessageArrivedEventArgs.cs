using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Definition_Of_Event 
{
    public class MessageArrivedEventArgs : EventArgs
    {
        private string message;
        public string Message
        {
            get
            {
                return message;
            }
        }
        public MessageArrivedEventArgs()
        {
            message = "No message sent.";
        }
        public MessageArrivedEventArgs(string newMessage)
        {
            message = newMessage;
        }
    }
}
