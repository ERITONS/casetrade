using CreditSuisse.TradeCategorizarion.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.TradeCategorizarion.Factory
{
    public  class TradeExpired : CategoryTrade
    {
        public string Category { get; private set; }

        public bool TradeCategorizarion(Trade trade)
        {
            TimeSpan daysLate = trade.ReferenceDate - trade.NextPaymentDate;
            bool tradeExpired = daysLate.Days > 30;

            if (tradeExpired)
                this.Category = "TradeExpired";
            else
                this.Category = "";

            return tradeExpired;
        }
    }
}
