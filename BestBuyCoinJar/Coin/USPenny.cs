namespace BestBuyCoinJar
{
    public class USPenny : USCoin
    {
        //this info comes from internet       
        private const double VolumeInCubicCentimeterForPeny = 0.36;
        private const double ValueInCentForPeny = 1;
        /// <summary>
        /// Constructor for USPenny, set the volume and value for USPenny
        /// </summary>
        public USPenny() : base(VolumeInCubicCentimeterForPeny, ValueInCentForPeny) { }
    }
}
