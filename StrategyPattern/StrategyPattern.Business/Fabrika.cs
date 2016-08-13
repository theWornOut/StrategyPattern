namespace StrategyPattern.Business
{
    public class Fabrika
    {
        public Fabrika(Strategy yontem)
        {
            yontem.Uretim();
        }

        /*public Fabrika()
        {
            SeriUretim s = new SeriUretim();
            s.Uretim();
        }*/
    }
}
