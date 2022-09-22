using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
