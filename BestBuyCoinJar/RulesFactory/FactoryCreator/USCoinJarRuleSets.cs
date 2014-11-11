using System.Collections.Generic;
namespace BestBuyCoinJar
{
    /// <summary>
    /// A Concrete 'Factory Creator' class
    /// </summary>
    class USCoinJarRuleSets : AbstractCoinJarRuleSets
    {
        public USCoinJarRuleSets(ICoinJar coinJar)
            : base(coinJar){}
        
        // Factory Method implementation
        public override void CreateRuleSets(ICoinJar usCoinJar)
        {
            RuleSets.Add(new USCoinRule(usCoinJar));
            RuleSets.Add(new MaxVolumeRule(usCoinJar));
        }
    }
 }