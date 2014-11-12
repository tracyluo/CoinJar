namespace BestBuyCoinJar
{
    /// <summary>
    /// Interface for coin
    /// </summary>
    public interface ICoin
    {
        /// <summary>
        /// The country code of the coin 
        /// </summary>
        CountryCodes CountryCode { get; }
        
        /// <summary>
        /// The volume of the coin in cubic centimeter 
        /// </summary>
        double VolumeInCubicCentimeter { get; }

        /// <summary>
        /// The value of the coin in cent
        /// </summary>
        double ValueInCent { get; }
    }
}
