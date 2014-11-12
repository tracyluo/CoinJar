namespace BestBuyCoinJar
{
    /// <summary>
    /// Coin Volume Converctor between Fluid Ounces and Cubic Centimeters
    /// </summary>
    public class CoinVolumeConvectorFluidOunces : ICoinVolumeConvector
    {
        /// <summary>
        /// The Convert Rate from FluidOunce to Cubic Centimeter is 29.574
        /// </summary>
        private const double ConvertRate = 29.574;

        /// <summary>
        /// Convert from Fluid Ounces to Cubic Centimeter
        /// </summary>
        /// <param name="volumeInFluidOunces">A <see cref="double"/> type representing a value in Fluid Ounces.</param>
        /// <returns>A <see cref="double"/> type representing a value in Cubic Centimeter.</returns>
        public double ConvertToCubicCentimeter(double volumeInFluidOunces)
        {
            return volumeInFluidOunces * ConvertRate;
        }
        /// <summary>
        /// Convert from Cubic Centimeter to Fluid Ounces
        /// </summary>
        /// <param name="volumeInCubicCentimeter">A <see cref="double"/> type representing a value in Cubic Centimeter.</param>
        /// <returns>A <see cref="double"/> type representing a value in Fluid Ounces.</returns>
        public double ConvertFromCubicCentimeter(double volumeInCubicCentimeter)
        {
            return volumeInCubicCentimeter / ConvertRate;
        }
    }
}