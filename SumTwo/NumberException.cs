using System;
namespace SumTwo
{
    public class NumberException : Exception
    {
        public NumberException(string text) : base("Number parsing error: " + text)
        {}
    }
}