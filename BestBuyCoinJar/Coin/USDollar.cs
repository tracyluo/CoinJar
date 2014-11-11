namespace BestBuyCoinJar
{
    public class USDollar : USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeter = 0.56;
        private const double ValueInCent = 100;
        
        public USDollar() : base(VolumeInCubicCentimeter, ValueInCent) { }
    }
}
