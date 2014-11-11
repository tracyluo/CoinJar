namespace BestBuyCoinJar
{
    interface ICoinValueConvector
    {
        double ConvertRate { get; }
        double ConvertToCent(double valueInOtherUnit);
        double ConvertFromCent(double valueInCent);
    }
}
