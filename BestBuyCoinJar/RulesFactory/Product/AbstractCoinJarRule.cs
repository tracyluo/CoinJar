namespace BestBuyCoinJar
{
    /// <summary>
    /// The  abstract 'Product' class
    /// </summary>
    public abstract class AbstractCoinJarRule
    {
        public ICoinJar _coinJar;

        public AbstractCoinJarRule(ICoinJar coinJar)
        {
            this._coinJar = coinJar;
        }

        public void CheckRuleAndAction(ICoin coin)
        {
            if (!CheckRule(coin))
            {
                ActionForViolation();
            }
        }
     
        // Check whether the rule is been violated
        public abstract bool CheckRule(ICoin coin);
    
        // Define the action when rule is been violated
        public abstract void ActionForViolation();
    }
}