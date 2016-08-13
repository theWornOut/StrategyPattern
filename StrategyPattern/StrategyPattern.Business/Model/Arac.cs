using System;

namespace StrategyPattern.Business
{
    public class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KM { get; set; }

        public Arac(string uretimTipi)
        {
            Console.WriteLine($"BMW, {uretimTipi} olan araç üretilmiştir.");
        }
    }
}
