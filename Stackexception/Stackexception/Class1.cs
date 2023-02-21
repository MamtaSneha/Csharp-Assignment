using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4ExceptionHandling_Q1
{
    class StackException : Exception
    {
        public StackException(string message) : base(message)
        {
        }
    }
}