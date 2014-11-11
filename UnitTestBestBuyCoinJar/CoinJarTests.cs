using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BestBuyCoinJar;

namespace UnitTestCoinJar
{
    [TestClass]
    public class CoinJarTests
    {
        [TestMethod]
        [ExpectedException(typeof(NotUSCoinException))]
        public void AcceptCoin_Should_Throw_ContryCodeException_When_Input_CACoin_to_USCoinJar()
        {
            //assign
            USCoinJar usCoinJar = new USCoinJar();
            CAPenny caPenny = new CAPenny();
            //arrange
            usCoinJar.AcceptCoin(caPenny);
            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowingException))]
        public void AcceptCoin_Should_Throw_OverflowingException_When_CoinJarActualVolume_Bigger_Than_CoinJarMaximumVolume()
        {
            //assign
            USCoinJar usCoinJar = new USCoinJar();
            double extendMaxVol = usCoinJar.MaximumVolumeInCubitCentimeter + 1 ;
            USCoin testCoin = new USCoin(extendMaxVol, 100);
            //arrange
            usCoinJar.AcceptCoin(testCoin);
            //assert
        }

        [TestMethod]
        public void AcceptCoin_Should_Update_CoinJar_CurrentVolume_When_Accept_Coin()
        {
            //assign
            USCoinJar usCoinJar = new USCoinJar();
            USPenny usPenny = new USPenny();
            //arrange
            double expect = usPenny.VolumeInCubicCentimetre;
            usCoinJar.AcceptCoin(usPenny);
            double actual = usCoinJar.CurrentVolumeInCubitCentimeter;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AcceptCoin_Should_Update_CoinJar_CurrentVolume_When_Accept_Multiple_Coins()
        {
            //assign
            USCoinJar usCoinJar = new USCoinJar();
            USPenny usPenny = new USPenny();
            USDollar usDollar = new USDollar();
            //arrange
            double expect = usPenny.VolumeInCubicCentimetre + usDollar.VolumeInCubicCentimetre;
            usCoinJar.AcceptCoin(usPenny);
            usCoinJar.AcceptCoin(usDollar);
            double actual = usCoinJar.CurrentVolumeInCubitCentimeter;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AcceptCoin_Should_Update_CoinJar_CurrentAmount_When_Accept_Coin()
        {
            //assign
            USCoinJar usCoinJar = new USCoinJar();
            USPenny usPenny = new USPenny();
            //arrange
            double expect = usPenny.ValueInCent;
            usCoinJar.AcceptCoin(usPenny);
            double actual = usCoinJar.CurrentAmountInCent;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void AcceptCoin_Should_Update_CoinJar_CurrentAmount_When_Accept_Multiple_Coins()
        {
            //assign
            USCoinJar usCoinJar = new USCoinJar();
            USPenny usPenny = new USPenny();
            USDollar usDollar = new USDollar();
            //arrange
            double expect = usPenny.ValueInCent + usDollar.ValueInCent;
            usCoinJar.AcceptCoin(usPenny);
            usCoinJar.AcceptCoin(usDollar);
            double actual = usCoinJar.CurrentAmountInCent;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void Reset_Should_Set_CoinJar_CurrentAmount_TO_ZERO()
        {
            //assign
            USCoinJar usCoinJar = new USCoinJar();
            USPenny usPenny = new USPenny();
            USDollar usDollar = new USDollar();
            //arrange
            double expect = 0;
            usCoinJar.AcceptCoin(usPenny);
            usCoinJar.AcceptCoin(usDollar);
            usCoinJar.Reset();
            double actual = usCoinJar.CurrentAmountInCent;
            //assert
            Assert.AreEqual(expect, actual);
        }
        [TestMethod]
        public void Reset_Should_Set_CoinJar_CurrentVolume_TO_ZERO()
        {
            //assign
            USCoinJar usCoinJar = new USCoinJar();
            USPenny usPenny = new USPenny();
            USDollar usDollar = new USDollar();
            //arrange
            double expect = 0;
            usCoinJar.AcceptCoin(usPenny);
            usCoinJar.AcceptCoin(usDollar);
            usCoinJar.Reset();
            double actual = usCoinJar.CurrentVolumeInCubitCentimeter;
            //assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void CoinJarCurrentAmount_Should_Return_One_CurrentAmount_Divide_ConvertRate()
        {
            //assign
            USCoinJar usCoinJar = new USCoinJar();
            CoinValueConvectorUSDollar cvcUSDollar = new CoinValueConvectorUSDollar();
            USDollar usDollar = new USDollar();
            //arrange
            double expect = usDollar.ValueInCent / cvcUSDollar.ConvertRate;
            usCoinJar.AcceptCoin(usDollar);
            double actual = usCoinJar.CoinJarCurrentAmount();
            //assert
            Assert.AreEqual(expect, actual);
        }
    }
}
