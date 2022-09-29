using CreditSuisse.TradeCategorizarion.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisse.TradeCategorizarion.Factory
{
    internal class HighRisk : Category
    {
        public string Name
        {
            get { return CategoryEnum.HighRisk.ToString(); }
        } 
        

        public bool Identifies(Trade trade)
        {
            return (trade.Value > 1000000 && trade.ClientSector.Equals("Private"));
        }
    }
}
