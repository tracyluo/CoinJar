namespace BestBuyCoinJar
{
    public class USHalfDollar : USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeter = 0.54;
        private const double ValueInCent = 50;

        public USHalfDollar() : base(VolumeInCubicCentimeter, ValueInCent) { }
    }
}