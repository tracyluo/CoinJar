namespace BestBuyCoinJar
{
    /// <summary>
    /// US coin
    /// </summary>
    public class USCoin : ICoin
    {
        private CountryCodes _countryCode;
        private double _volume;
        private double _value;

        /// <summary>
        /// Constructor for USCoin, can be used create any USCoin, convient for unit test
        /// </summary>
        public USCoin(double volume, double value)
        {
            this._countryCode = CountryCodes.US;
            this._value = value;
            this._volume = volume;

        }

        /// <summary>
        /// Country code of the US coin
        /// </summary>
        public CountryCodes CountryCode
        {
            get { return _countryCode; }
        }

        /// <summary>
        /// Volume of the US coin in cubic centimeter
        /// </summary>
        public double VolumeInCubicCentimeter
        {
            get { return _volume; }
        }

        /// <summary>
        /// Value of the US coin in cent
        /// </summary>
        public double ValueInCent
        {
            get { return _value; }
        }


    }
}
