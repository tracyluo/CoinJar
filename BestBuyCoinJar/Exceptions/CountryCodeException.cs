using System;

namespace BestBuyCoinJar
{
    /// <summary>
    /// NotUSCoinException
    /// </summary>
    public class NotUSCoinException: Exception
    {
        public NotUSCoinException()
        {
        }

        public NotUSCoinException(string message)
            : base(message)
        {
        }

        public NotUSCoinException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
