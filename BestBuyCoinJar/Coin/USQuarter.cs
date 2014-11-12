namespace BestBuyCoinJar
{
    public class USQuarter : USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeterForQuarter = 0.56;
        private const double ValueInCentForQuarter = 25;
        /// <summary>
        /// Constructor for USQuarter, set the volume and value for USPenny
        /// </summary>
        public USQuarter() : base(VolumeInCubicCentimeterForQuarter, ValueInCentForQuarter) { }
    }
}
