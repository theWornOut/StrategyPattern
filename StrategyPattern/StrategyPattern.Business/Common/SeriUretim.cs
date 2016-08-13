namespace StrategyPattern.Business
{
    public class SeriUretim : Strategy
    {
        public override Arac Uretim()
        {
            return new Arac("Seri üretim");
        }

        /*public Arac Uretim()
        {
            return new Arac("Seri üretim");
        }*/
    }
}
