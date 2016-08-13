namespace StrategyPattern.Business
{
    public class OzelYapimUretim : Strategy
    {
        public override Arac Uretim()
        {
            return new Arac("Özel yapım üretim");
        }

        /*public Arac Uretim()
        {
            return new Arac("Özel yapım üretim");
        }*/
    }
}
