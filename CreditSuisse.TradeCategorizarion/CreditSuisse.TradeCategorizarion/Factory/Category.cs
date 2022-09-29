using CreditSuisse.TradeCategorizarion.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.TradeCategorizarion.Factory
{

    //category class:defines de caracterists and behavior of category
    public interface Category
    {
        string Name { get; }
        bool Identifies(Trade trade);
    }
}
