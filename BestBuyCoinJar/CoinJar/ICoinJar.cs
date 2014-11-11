using System.Collections.Generic;

namespace BestBuyCoinJar
{
    public enum CountryCodes {US, CA};
    public interface ICoinJar
    {
        double MaximumVolumeInCubitCentimeter { get;  }
        double CurrentVolumeInCubitCentimeter{get;}
        double CurrentAmountInCent { get; }
        CountryCodes CountryCode { get; }
        void Reset();
        void AcceptCoin(ICoin coin);
        double CoinJarCurrentAmount();
        List<AbstractCoinJarRule> RuleSets {get; }
    }
}
