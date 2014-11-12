using System.Collections.Generic;
namespace BestBuyCoinJar
{
    /// <summary>
    /// A Concrete 'Factory Creator' class
    /// </summary>
    class USCoinJarRuleSets : AbstractCoinJarRuleSets
    {
       /// <summary>
       /// Constructor of USCoinJarRuleSets
       /// </summary>
       /// <param name="coinJar"></param>
        public USCoinJarRuleSets(ICoinJar coinJar)
            : base(coinJar){}
        
      
        /// <summary>
        /// Factory Method implementation, populate <paramref name="notOverFlowing"/>
        /// </summary>
        /// <param name="usCoinJar">A <see cref="ICoinJar"/> type representing a coinjar.</param>
        public override void CreateRuleSets(ICoinJar usCoinJar)
        {
            RuleSets.Add(new USCoinRule(usCoinJar));
            RuleSets.Add(new MaxVolumeRule(usCoinJar));
        }
    }
 }