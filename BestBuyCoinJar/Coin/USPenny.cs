namespace BestBuyCoinJar
{
    public class USPenny : USCoin
    {
        //this info comes from internet       
        private const double VolumeInCubicCentimeter = 0.36;
        private const double ValueInCent = 1;
        
        public USPenny() : base(VolumeInCubicCentimeter, ValueInCent) { }
    }
}
