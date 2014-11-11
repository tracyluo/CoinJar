using System;

namespace BestBuyCoinJar
{
    public class OverflowingException: Exception
    {
        public OverflowingException()
        {
        }

        public OverflowingException(string message)
            : base(message)
        {
        }

        public OverflowingException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
