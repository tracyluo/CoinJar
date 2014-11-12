using System.Collections.Generic;
namespace BestBuyCoinJar
{
    /// <summary>
    /// The abstract 'Factory Creator' class
    /// </summary>
    abstract class AbstractCoinJarRuleSets
    {
        private List<AbstractCoinJarRule> _ruleSets = new List<AbstractCoinJarRule>();

        /// <summary>
        /// Constructor calls abstract Factory method
        /// </summary>
        /// <param name="coinJar">A <see cref="ICoinJar"/> type representing a coinjar.</param>
        public AbstractCoinJarRuleSets(ICoinJar coinJar)
        {
            this.CreateRuleSets(coinJar);
        }
        
        /// <summary>
        /// RuleSets List
        /// </summary>
        public List<AbstractCoinJarRule> RuleSets
        {
            get { return _ruleSets; }
        }

        /// <summary>
        /// Factory Method
        /// </summary>
        /// <param name="coinJar"></param>
        public abstract void CreateRuleSets(ICoinJar coinJar);
    }
 
}
