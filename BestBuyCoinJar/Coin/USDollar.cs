namespace BestBuyCoinJar
{
    public class USDollar : USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeterForDollar = 0.56;
        private const double ValueInCentForDollar = 100;
        /// <summary>
        /// Constructor for USDollar, set the volume and value for USPenny
        /// </summary>
        public USDollar() : base(VolumeInCubicCentimeterForDollar, ValueInCentForDollar) { }
    }
}
