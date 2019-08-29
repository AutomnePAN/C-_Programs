using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Method_and_Parameters
{
    
    class MyClass
    {
        private string myString;

        public readonly string Name;
        private int intVal;
        public int Val
        {
            get
            {
                return intVal;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    intVal = value;
                }
                else
                {
                    throw (new ArgumentOutOfRangeException("value", value, "must be in [0,10]"));
                }
            }
        }

        public string MyString { get => myString; set => myString = value; }

        public override string ToString()
        {
            return "Name: " + Name + "\nVal: " + intVal;
        
        }

        private MyClass():this("Defaut Name")
        {

        }

        #region method
        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
        #endregion
    }
}
