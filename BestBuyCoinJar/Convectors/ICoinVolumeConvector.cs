
namespace BestBuyCoinJar
{
    /// <summary>
    /// Interface ICoinVolumeConvector
    /// </summary>
    interface ICoinVolumeConvector
    {
        /// <summary>
        /// Convert from other coin volume unit to cubic centimeter
        /// </summary>
        /// <param name="volumeInOtherUnit">A <see cref="double"/> type representing a value in other coin volume unit.</param>
        /// <returns>A <see cref="double"/> type representing a value in cubic centimeter.</returns>
        double ConvertToCubicCentimeter(double volumeInOtherUnit);
      
        /// <summary>
        /// Convert from cubic centimeter to other coin volume unit
        /// </summary>
        /// <param name="volumeInCubicCentimeter">A <see cref="double"/> type representing a value in cubic centimeter.</param>
        /// <returns>A <see cref="double"/> type representing a value in other coin volume unit.</returns>
        double ConvertFromCubicCentimeter(double volumeInCubicCentimeter);
    }
}
