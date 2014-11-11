namespace BestBuyCoinJar
{
    public class USDime : USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeter = 0.36;
        private const double ValueInCent = 10;

        public USDime() : base(VolumeInCubicCentimeter, ValueInCent) { }
    }
}
