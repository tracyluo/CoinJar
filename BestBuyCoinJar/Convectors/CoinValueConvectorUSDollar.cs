namespace BestBuyCoinJar
{
    public class CoinValueConvectorUSDollar : ICoinValueConvector
    {
        private double _convertRate = 100;

        public double ConvertToCent(double valueInUSDollar)
        {
            return valueInUSDollar * _convertRate;
        }

        public double ConvertFromCent(double valueInCent)
        {
            return valueInCent / _convertRate;
        }

        public double ConvertRate
        {
            get { return _convertRate; }
        }


    }
}
