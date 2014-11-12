using System.Collections.Generic;

namespace BestBuyCoinJar
{
    /// <summary>
    /// A concrete coin jar
    /// </summary>
    public class USCoinJar : ICoinJar
    {
        private double _maxVol;
        private double _currVol;
        private double _currAmt;
        private List<AbstractCoinJarRule> _ruleSets;
        private const double MaxVolumeFluidOunces = 32;

        /// <summary>
        /// Constructor of the coin jar, initiation and reset
        /// </summary>
        public USCoinJar()
        {
            CoinVolumeConvectorFluidOunces volumeFO = new CoinVolumeConvectorFluidOunces();
            this._maxVol = volumeFO.ConvertToCubicCentimeter(MaxVolumeFluidOunces);
            USCoinJarRuleSets myUSCoinJarRuleSets = new USCoinJarRuleSets(this);
            this._ruleSets = myUSCoinJarRuleSets.RuleSets;
            this.Reset();
        }

        /// <summary>
        /// Check all rules for the jar, if all rules are followed, update the volume and amount of the jar
        /// </summary>
        /// <param name="coin">A <see cref="ICoin"/> type representing a coin.</param>
        public void AcceptCoin(ICoin coin)
        {
            foreach (AbstractCoinJarRule cjRule in this._ruleSets)
            {
                cjRule.CheckRuleAndAction(coin);
            }
            // when it get to this point, means every rule has been passed
            this._currAmt += coin.ValueInCent;
            this._currVol += coin.VolumeInCubicCentimeter;
        }

        /// <summary>
        /// Get the coin amount in the jar in us dollar
        /// </summary>
        /// <returns>A <see cref="double"/> type representing money amount in us dollar.</returns>
        public double CoinJarCurrentAmount()
        {
            CoinValueConvectorUSDollar cvcUSDollar = new CoinValueConvectorUSDollar();
            return cvcUSDollar.ConvertFromCent(this._currAmt);
        }

        /// <summary>
        /// Reset jar volume and amount
        /// </summary>
        public void Reset()
        {
            this._currVol = 0;
            this._currAmt = 0;
        }

        /// <summary>
        /// The maximum volume of the coin jar in cubic centimeter
        /// </summary>
        public double MaximumVolumeInCubicCentimeter
        {
            get { return _maxVol; }
        }

        /// <summary>
        /// The occupied volume of the coin jar in cubic centimeter
        /// </summary>
        public double CurrentVolumeInCubicCentimeter
        {
            get { return _currVol; }
        }

        /// <summary>
        /// The money amount of coin jar in cents
        /// </summary>
        public double CurrentAmountInCent
        {
            get { return _currAmt; }
        }

        /// <summary>
        /// The list of the coin jar rules
        /// </summary>
        public List<AbstractCoinJarRule> RuleSets
        {
            get { return _ruleSets; }
        }
    }
}
