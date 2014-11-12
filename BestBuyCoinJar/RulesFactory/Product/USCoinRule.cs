namespace BestBuyCoinJar
{
    /// <summary>
    /// A Concrete 'Product' class
    /// </summary>
    class USCoinRule : AbstractCoinJarRule
    {
        public USCoinRule(ICoinJar coinJar)
            : base(coinJar){}
       
        /// <summary>
        /// Check whether the Coin is a USCoin
        /// </summary>
        /// <param name="coin">  A <see cref="ICoin"/> type representing a coin.</param>
        /// <returns><paramref name="isUSCoin"/></returns>
        public override bool CheckRule(ICoin coin)
        {
            bool isUSCoin = true;

            if (coin.GetType()!= typeof(USCoin) && coin.GetType().BaseType != typeof(USCoin))
            {
                isUSCoin = false;
            }
            return isUSCoin;
        }
       
        /// <summary>Action when violate USCoinRule</summary>
        /// <exception cref="NotUSCoinException">
        /// </exception>
        public override void ActionForViolation()
        {
            throw new NotUSCoinException();
        }
    }
}
