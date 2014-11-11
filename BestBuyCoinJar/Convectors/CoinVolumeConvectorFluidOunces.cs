namespace BestBuyCoinJar
{
    public class CoinVolumeConvectorFluidOunces : ICoinVolumeConvector
    {

        private const double ConvertRate = 29.574;

        public double ConvertToCubicCentimeter(double volumeInFluidOunces)
        {
            return volumeInFluidOunces * ConvertRate;
        }

        public double ConvertFromCubicCentimeter(double volumeInCubicCentimeter)
        {
            return volumeInCubicCentimeter / ConvertRate;
        }
    }
}