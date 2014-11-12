namespace BestBuyCoinJar
{
    public class USDime : USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeterforDime = 0.36;
        private const double ValueInCentforDime = 10;
        /// <summary>
        /// Constructor for USDime, set the volume and value for USDime
        /// </summary>
        public USDime() : base(VolumeInCubicCentimeterforDime, ValueInCentforDime) { }
    }
}
