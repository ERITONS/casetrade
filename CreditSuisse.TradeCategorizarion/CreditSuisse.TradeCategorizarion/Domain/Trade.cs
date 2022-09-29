using CreditSuisse.TradeCategorizarion.Factory;

namespace CreditSuisse.TradeCategorizarion.Domain
{
    public class Trade : ITrade
    {
        public double Value { get; set; }

        public string ClientSector { get; set; }

        public DateTime NextPaymentDate { get; set; }

        public DateTime ReferenceDate { get; set; }


        public Trade(double Value, string ClientSector, DateTime NextPaymentData, DateTime ReferenceDate)
        {
            this.Value = Value;
            this.ClientSector = ClientSector;
            this.NextPaymentDate = NextPaymentData;
            this.ReferenceDate = ReferenceDate;
        }

        public Trade()
        { 
        }

        public bool TradeCategorizarion(Category category)
        {
            return category.Identifies(this);
        }

        public List<ITrade> GenerateTradeList()
        {
            List<ITrade> trades = new()
            {
                new Trade(2000000, "Private", new DateTime(2025, 12, 29),new DateTime(2020, 12, 11)),
                new Trade(4000000, "Public", new DateTime(2020, 07, 01),new DateTime(2020, 12, 11)),
                new Trade(5000000, "Public", new DateTime(2024, 01, 02),new DateTime(2020, 12, 11)),
                new Trade(3000000, "Public", new DateTime(2023, 10, 26),new DateTime(2020, 12, 11))
            };

            return trades;  
        }
    }
}
