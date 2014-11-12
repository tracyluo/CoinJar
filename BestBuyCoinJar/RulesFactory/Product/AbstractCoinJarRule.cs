namespace BestBuyCoinJar
{
    /// <summary>
    /// The  abstract 'Product' class
    /// </summary>
    public abstract class AbstractCoinJarRule
    {
        public ICoinJar _coinJar;
        /// <summary>
        /// Constructor for the Abstract class
        /// </summary>
        /// <param name="coinJar">A <see cref="ICoinJar"/> type representing a coinjar.</param>
        public AbstractCoinJarRule(ICoinJar coinJar)
        {
            this._coinJar = coinJar;
        }

        /// <summary>
        ///  Check the rule, do the corresponded action if the rule is been violated
        /// </summary>
        /// <param name="coin">A <see cref="ICoin"/> type representing a coin.</param>
        public void CheckRuleAndAction(ICoin coin)
        {
            if (!CheckRule(coin))
            {
                ActionForViolation();
            }
        }

        /// <summary>
        /// Check whether the rule is been violated
        /// </summary>
        /// <param name="coin">A <see cref="ICoin"/> type representing a coin.</param>
        /// <returns>A <see cref="bool"/> type representing a result of the rule checking.</returns>
        public abstract bool CheckRule(ICoin coin);
    
        /// <summary>
        /// Define the action when rule is been violated
        /// </summary>
        public abstract void ActionForViolation();
    }
}