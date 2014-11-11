namespace BestBuyCoinJar
{
    class USNikel:USCoin
    {
        //ToDo: the volume now is a fake number, investigate the real volume       
        private const double VolumeInCubicCentimeter = 0.40;
        private const double ValueInCent = 5;
        
        public USNikel() : base(VolumeInCubicCentimeter, ValueInCent) { }
    }
}
