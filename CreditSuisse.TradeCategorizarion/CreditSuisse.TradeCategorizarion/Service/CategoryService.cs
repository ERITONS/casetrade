using CreditSuisse.TradeCategorizarion.Domain;
using CreditSuisse.TradeCategorizarion.Business;

namespace CreditSuisse.TradeCategorizarion.Service
{
    class CategoryService
    {
        private List<ITrade> trades;

        public CategoryService(List<ITrade> trades)
        {
            this.trades = trades;
        }

        public List<string> GetCategories()
        {
           

            List<string> tradeCategories = new List<string>();

            List<Category> categories = new List<Category> {
                new Expired(),
                new HighRisk(),
                new MediumRisk(),
                new Expired()
            };


            //category loop: will try to categorize the trad with each tradcategory that existis on enum.
            foreach (Trade trade in trades)
            {
                foreach (Category category in categories)
                {
                   
                    if (category.Identifies(trade))
                    {
                        tradeCategories.Add(category.Name);
                        break;
                    }
            
                }
            }

            return tradeCategories;
        }
    }
}
