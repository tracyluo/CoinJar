namespace BestBuyCoinJar
{
    public class CAPenny : CACoin
    {
        //this info comes from internet       
        private const double VolumeInCubicCentimeterForPeny = 0.34;
        private const double ValueInCentForPeny = 1;
        /// <summary>
        /// Constructor for CAPenny, set the volume and value for CAPenny
        /// </summary>
        public CAPenny() : base(VolumeInCubicCentimeterForPeny, ValueInCentForPeny) { }
    }
}
