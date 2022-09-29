

namespace CreditSuisse.TradeCategorizarion.Domain
{
    public interface ITrade
    {
       double Value { get;  }

        string ClientSector { get;  }

        DateTime NextPaymentDate { get;  }

        DateTime ReferenceDate { get;}
    }
}
