namespace BestBuyCoinJar
{
    /// <summary>
    ///  Coin Value Convertor between US Dollar and Cent
    /// </summary>
    public class CoinValueConvectorUSDollar : ICoinValueConvector
    {
        /// <summary>
        /// Convert rate from US Dollar to Cent is 100
        /// </summary>
        private double _convertRate = 100;

        /// <summary>
        /// Convert from US Dollar to cent
        /// </summary>
        /// <param name="valueInUSDollar">A <see cref="double"/> type representing a value in US Dollar.</param>
        /// <returns>A <see cref="double"/> type representing a value in cent.</returns>
        public double ConvertToCent(double valueInUSDollar)
        {
            return valueInUSDollar * _convertRate;
        }

        /// <summary>
        /// Convert from cent to US Dollar
        /// </summary>
        /// <param name="valueInCent">A <see cref="double"/> type representing a value in US Cent.</param>
        /// <returns>A <see cref="double"/> type representing a value in US Dollar.</returns>
        public double ConvertFromCent(double valueInCent)
        {
            return valueInCent / _convertRate;
        }

        /// <summary>
        /// the ConvertRate from US Dollar to Cent
        /// </summary>
        public double ConvertRate
        {
            get { return _convertRate; }
        }


    }
}
