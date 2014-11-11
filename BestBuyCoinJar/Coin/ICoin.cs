namespace BestBuyCoinJar
{
    public interface ICoin
    {
        CountryCodes CountryCode { get; }
        double VolumeInCubicCentimetre { get; }
        double ValueInCent { get; }
    }
}
