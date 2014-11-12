namespace BestBuyCoinJar
{
    public class USHalfDollar : USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeterForHalfDollar = 0.54;
        private const double ValueInCentForHalfDollar = 50;
        /// <summary>
        /// Constructor for USHalfDollar, set the volume and value for USPenny
        /// </summary>
        public USHalfDollar() : base(VolumeInCubicCentimeterForHalfDollar, ValueInCentForHalfDollar) { }
    }
}