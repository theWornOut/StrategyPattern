namespace StrategyPattern.Business
{
    public class SiparisIleUretim : Strategy
    {
        public override Arac Uretim()
        {
            return new Arac("Sipariş ile üretim");
        }

        /*public Arac Uretim()
        {
            return new Arac("Sipariş ile üretim");
        }*/
    }
}
