using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryRules;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            USCoinJar usCoinJar = new USCoinJar();
            CAPenny caPenny = new CAPenny();
            usCoinJar.AcceptCoin(caPenny);
        }
    }
}
