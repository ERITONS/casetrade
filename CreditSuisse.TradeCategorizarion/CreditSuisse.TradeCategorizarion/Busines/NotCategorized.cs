using CreditSuisse.TradeCategorizarion.Domain;

namespace CreditSuisse.TradeCategorizarion.Factory
{
    internal class NotCategorized : Category
    {
        public string Name {
            get { return CategoryEnum.NotCategorized.ToString(); }
         }
        public bool Identifies(Trade trade)
        {
            return true;
        }
    }
}
