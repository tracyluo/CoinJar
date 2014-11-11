
namespace BestBuyCoinJar
{
    interface ICoinVolumeConvector
    {
        double ConvertToCubicCentimeter(double volumeInOtherUnit);
        double ConvertFromCubicCentimeter(double volumeInCubicCentimeter);
    }
}
