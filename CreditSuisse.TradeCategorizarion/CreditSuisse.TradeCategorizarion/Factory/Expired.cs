using CreditSuisse.TradeCategorizarion.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.TradeCategorizarion.Factory
{
    public  class Expired : Category
    {
        public string Name
        {
            get { return CategoryEnum.Expired.ToString(); }
        }

        public bool Identifies(Trade trade)
        {
            TimeSpan daysLate = trade.ReferenceDate - trade.NextPaymentDate;
            return daysLate.Days > 30;
        }
    }
}
