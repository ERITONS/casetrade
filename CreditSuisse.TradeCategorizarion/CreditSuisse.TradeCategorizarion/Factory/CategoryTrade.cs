using CreditSuisse.TradeCategorizarion.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.TradeCategorizarion.Factory
{
    public interface CategoryTrade
    {
        string Category { get; }
        bool TradeCategorizarion(Trade trade);
    }
}
