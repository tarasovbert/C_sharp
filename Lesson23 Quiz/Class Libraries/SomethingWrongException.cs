using System;

namespace Class_Libraries
{
    public class SomethingWrongException: Exception
    {
        public SomethingWrongException(string text):base(text) {}
    }
}
