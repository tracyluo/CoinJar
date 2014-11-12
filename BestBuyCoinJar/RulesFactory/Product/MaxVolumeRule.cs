namespace BestBuyCoinJar
{
    /// <summary>
    /// A Concrete 'Product' class
    /// </summary>
    class MaxVolumeRule : AbstractCoinJarRule
    {
        public MaxVolumeRule(ICoinJar coinJar)
            : base(coinJar){}
        /// <summary>
        /// Check whether the jar is overflowing after accepted the coin
        /// </summary>
        /// <param name="coin">A <see cref="ICoin"/> type representing a coin.</param>
        /// <returns><paramref name="notOverFlowing"/></returns>
        public override bool CheckRule(ICoin coin)
        {
            bool notOverFlowing = true;
            if (this._coinJar.CurrentVolumeInCubicCentimeter + coin.VolumeInCubicCentimeter > this._coinJar.MaximumVolumeInCubicCentimeter)
            {
                notOverFlowing = false;
            }
            return notOverFlowing;
        }
        
        /// <summary>action when violate MaxVolumeRule</summary>
        /// <exception cref="OverflowingException">
        /// </exception>
        public override void ActionForViolation()
        {
            throw new OverflowingException();
        }
    }
}
