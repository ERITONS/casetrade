using CreditSuisse.TradeCategorizarion.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
