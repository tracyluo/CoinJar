namespace BestBuyCoinJar
{
    public class USQuarter : USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeter = 0.56;
        private const double ValueInCent = 25;

        public USQuarter() : base(VolumeInCubicCentimeter, ValueInCent) { }
    }
}
