using System;
using System.Collections.Generic;
using System.Text;

namespace TextEditor
{
    public class MyException : Exception
    {
        public MyException() : base() { }
        public MyException(string message) : base (message) { }
        public override string ToString()
        {
            return Message; 
        }
    }
}
