namespace BestBuyCoinJar
{
    public class CACoin : ICoin
    {
        private CountryCodes _countryCode;
        private double _volume;
        private double _value;

        public CACoin(double volume, double value)
        {
            this._countryCode = CountryCodes.CA;
            this._value = value;
            this._volume = volume;
        }

        public CountryCodes CountryCode
        {
            get { return _countryCode; }
        }

        public double VolumeInCubicCentimetre
        {
            get { return _volume; }
        }

        public double ValueInCent
        {
            get { return _value; }
        }
    }
}
