namespace BestBuyCoinJar
{
    /// <summary>
    /// A Concrete 'Product' class
    /// </summary>
    class USCoinRule : AbstractCoinJarRule
    {
        public USCoinRule(ICoinJar coinJar)
            : base(coinJar){}
        
        public override bool CheckRule(ICoin coin)
        {
            bool pass = true;

            if (coin.GetType()!= typeof(USCoin) && coin.GetType().BaseType != typeof(USCoin))
            {
                pass = false;
            }
            return pass;
        }

        public override void ActionForViolation()
        {
            throw new NotUSCoinException();
        }
    }
}
