namespace BestBuyCoinJar
{
    /// <summary>
    /// Canadian coin
    /// </summary>
    public class CACoin : ICoin
    {
        private CountryCodes _countryCode;
        private double _volume;
        private double _value;
        /// <summary>
        /// Constructor for CACoin, can be used create any CACoin, convient for unit test
        /// </summary>
        public CACoin(double volume, double value)
        {
            this._countryCode = CountryCodes.CA;
            this._value = value;
            this._volume = volume;
        }

        /// <summary>
        /// Country code of the canadian coin
        /// </summary>
        public CountryCodes CountryCode
        {
            get { return _countryCode; }
        }

        /// <summary>
        /// Volume of the canadian coin in cubic centimeter
        /// </summary>
        public double VolumeInCubicCentimeter
        {
            get { return _volume; }
        }

        /// <summary>
        /// Value of the canadian coin in cent
        /// </summary>
        public double ValueInCent
        {
            get { return _value; }
        }
    }
}
