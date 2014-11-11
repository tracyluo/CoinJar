using System.Collections.Generic;

namespace BestBuyCoinJar
{
    public class USCoinJar : ICoinJar
    {
        private double _maxVol;
        private double _currVol;
        private double _currAmt;
       private CountryCodes _countryCode;
        private List<AbstractCoinJarRule> _ruleSets;
        private const double MaxVolumeFluidOunces = 32;

        public USCoinJar()
        {
            CoinVolumeConvectorFluidOunces volumeFO = new CoinVolumeConvectorFluidOunces();
            this._maxVol = volumeFO.ConvertToCubicCentimeter(MaxVolumeFluidOunces);
          //  this._countryCode = CountryCodes.US;
            USCoinJarRuleSets myUSCoinJarRuleSets = new USCoinJarRuleSets(this);
            this._ruleSets = myUSCoinJarRuleSets.RuleSets;
            this.Reset();
        }

        public void AcceptCoin(ICoin coin)
        {
            foreach (AbstractCoinJarRule cjRule in this._ruleSets)
            {
                cjRule.CheckRuleAndAction(coin);
            }
            // when it get to this point, means every rule has been passed
            this._currAmt += coin.ValueInCent;
            this._currVol += coin.VolumeInCubicCentimetre;
        }

        public double CoinJarCurrentAmount()
        {
            CoinValueConvectorUSDollar cvcUSDollar = new CoinValueConvectorUSDollar();
            return cvcUSDollar.ConvertFromCent(this._currAmt);
        }

        public void Reset()
        {
            this._currVol = 0;
            this._currAmt = 0;
        }

        public double MaximumVolumeInCubitCentimeter
        {
            get { return _maxVol; }
        }

        public double CurrentVolumeInCubitCentimeter
        {
            get { return _currVol; }
        }

        public double CurrentAmountInCent
        {
            get { return _currAmt; }
        }

        public List<AbstractCoinJarRule> RuleSets
        {
            get { return _ruleSets; }
        }

        public CountryCodes CountryCode
        {
            get { return _countryCode; }
        }
    }
}
