using System.Collections.Generic;

namespace BestBuyCoinJar
{
    /// <summary>
    /// Enum of Country Codes, every coin has a country code
    /// </summary>
    public enum CountryCodes {US, CA};

    /// <summary>
    /// Interface of coin jar
    /// </summary>
    public interface ICoinJar
    {
        /// <summary>
        /// Maximum value of a coin jar in cubic centimeter
        /// </summary>
        double MaximumVolumeInCubicCentimeter { get;  }
       
        /// <summary>
        /// Occupied volume of a coin jar in cubic centimeter
        /// </summary>
        double CurrentVolumeInCubicCentimeter{get;}

        /// <summary>
        /// Amount of a coin jar in cent
        /// </summary>
        double CurrentAmountInCent { get; }
        
        /// <summary>
        /// Reset coin jar status
        /// </summary>
        void Reset();
        
        /// <summary>
        /// Checking all the rules of the coin jar and do corresponded action
        /// </summary>
        /// <param name="coin"> A <see cref="ICoin"/> type representing a coin.</param>
        void AcceptCoin(ICoin coin);

        /// <summary>
        /// Amount of the coin jar amount in specific money unit
        /// </summary>
        /// <returns> A <see cref="double"/> type representing coin jar amount in specific money unit.</returns>
        double CoinJarCurrentAmount();

        /// <summary>
        /// The list of rules to verify whether the coin will be accepted by the jar
        /// </summary>
        List<AbstractCoinJarRule> RuleSets {get; }
    }
}
