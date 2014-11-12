using System;

namespace BestBuyCoinJar
{
    /// <summary>
    /// OverFlowingException
    /// </summary>
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
