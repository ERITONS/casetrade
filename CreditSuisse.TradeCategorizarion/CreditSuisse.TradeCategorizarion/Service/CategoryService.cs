using CreditSuisse.TradeCategorizarion.Domain;
using CreditSuisse.TradeCategorizarion.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            CategoryTrade category = null;

            List<string> tradeCategories = new List<string>();

            List<CategoryTrade> categories = new List<CategoryTrade> {
                 CategoryFactory.Create(CategoryEnum.TradeExpired),
                CategoryFactory.Create(CategoryEnum.TradeHighRisk),
                CategoryFactory.Create(CategoryEnum.TradeMediumRisk)
            };

            foreach (Trade trade in trades)
            {
                foreach (CategoryTrade r in categories)
                {
                    category = r;

                    if (trade.TradeCategorizarion(r))
                    {
                        break;
                    }
                }

                tradeCategories.Add(category.Category);
            }

            return tradeCategories;
        }
    }
}
