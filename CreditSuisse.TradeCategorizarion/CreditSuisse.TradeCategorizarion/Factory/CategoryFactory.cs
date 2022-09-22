using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.TradeCategorizarion.Factory
{
    static class CategoryFactory
    {
        public static CategoryTrade Create(CategoryEnum category)
        {
            return Create(category.ToString());
        }

        public static CategoryTrade Create(string category)
        {
            switch (category)
            {
                case "TradeExpired":
                    return new TradeExpired();
                case "TradeHighRisk":
                    return new TradeHighRisk();
                case "TradeMediumRisk":
                    return new TradeMediumRisk();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
