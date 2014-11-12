namespace BestBuyCoinJar
{
    class USNikel:USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeterForNikel = 0.40;
        private const double ValueInCentForNikel = 5;
        /// <summary>
        /// Constructor for USNikel, set the volume and value for USPenny
        /// </summary>
        public USNikel() : base(VolumeInCubicCentimeterForNikel, ValueInCentForNikel) { }
    }
}
