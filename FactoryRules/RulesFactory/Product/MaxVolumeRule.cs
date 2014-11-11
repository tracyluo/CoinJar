namespace BestBuyCoinJar
{
    /// <summary>
    /// A Concrete 'Product' class
    /// </summary>
    class MaxVolumeRule : AbstractCoinJarRule
    {
        public MaxVolumeRule(ICoinJar coinJar)
            : base(coinJar){}
        
        public override bool CheckRule(ICoin coin)
        {
            bool pass = true;
            if (this._coinJar.CurrentVolumeInCubitCentimeter + coin.VolumeInCubicCentimetre > this._coinJar.MaximumVolumeInCubitCentimeter)
            {
                pass = false;
            }
            return pass;
        }

        public override void ActionForViolation()
        {
            throw new OverflowingException();
        }
    }
}
