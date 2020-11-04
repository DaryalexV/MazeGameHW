using System;

namespace MazeGame
{
    public sealed class MyException : Exception
    {
        public int Value { get;}
        public MyException(string message, int val) : base(message)
        {
            Value = val;
        }
    }
}
