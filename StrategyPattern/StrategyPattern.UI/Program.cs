using StrategyPattern.Business;
using System;

namespace StrategyPattern.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            OzelYapimUretim oyUret = new OzelYapimUretim();
            SeriUretim sUret = new SeriUretim();
            SiparisIleUretim suUret = new SiparisIleUretim();
            Fabrika uret1 = new Fabrika(oyUret);
            Fabrika uret2 = new Fabrika(sUret);
            Fabrika uret3 = new Fabrika(suUret);

            Console.Read();
        }
    }
}
