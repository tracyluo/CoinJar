using System.Collections.Generic;
namespace BestBuyCoinJar
{
    /// <summary>
    /// The abstract 'Factory Creator' class
    /// </summary>
    abstract class AbstractCoinJarRuleSets
    {
        private List<AbstractCoinJarRule> _ruleSets = new List<AbstractCoinJarRule>();

        // Constructor calls abstract Factory method
        public AbstractCoinJarRuleSets(ICoinJar coinJar)
        {
            this.CreateRuleSets(coinJar);
        }

        public List<AbstractCoinJarRule> RuleSets
        {
            get { return _ruleSets; }
        }

        // Factory Method
        public abstract void CreateRuleSets(ICoinJar coinJar);
    }
 
}
