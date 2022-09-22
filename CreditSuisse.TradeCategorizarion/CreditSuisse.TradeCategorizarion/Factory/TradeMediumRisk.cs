using CreditSuisse.TradeCategorizarion.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.TradeCategorizarion.Factory
{
    public class TradeMediumRisk : CategoryTrade
    {
        public string Category { get; private set; }
        public bool TradeCategorizarion(Trade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector.Equals("Public"))
            {
                Category = "TradeMediumRisk";
                return true;
            }

            Category = "";

            return false;
        }
    }
}
