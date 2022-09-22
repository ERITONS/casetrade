using CreditSuisse.TradeCategorizarion.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.TradeCategorizarion.Factory
{
    internal class TradeHighRisk : CategoryTrade
    {
        public string Category { get; private set; }
        public bool TradeCategorizarion(Trade trade)
        {
            if (trade.Value > 1000000 && trade.ClientSector.Equals("Private"))
            {
                this.Category = "TradeHighRisk";
                return true;
            }

       
           this.Category = "";

            return false;
        }
    }
}
