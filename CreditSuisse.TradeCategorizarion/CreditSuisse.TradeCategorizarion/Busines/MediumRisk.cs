using CreditSuisse.TradeCategorizarion.Domain;

namespace CreditSuisse.TradeCategorizarion.Factory
{
    public class MediumRisk : Category
    {
        public string Name {

            get { return CategoryEnum.MediumRisk.ToString(); }
        }
        public bool Identifies(Trade trade)
        {
            return (trade.Value > 1000000 && trade.ClientSector.Equals("Public"));
        }
    }
}
