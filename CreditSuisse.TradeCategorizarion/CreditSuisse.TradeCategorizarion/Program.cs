//entrepoint .net 6.0 style top-level-templates

using CreditSuisse.TradeCategorizarion.Domain;
using CreditSuisse.TradeCategorizarion.Service;

Trade trade = new Trade();

var trades = trade.GenerateTradeList();

//var teste = new Trade(4000000, "Public", new DateTime(2020, 07, 01), new DateTime(2020, 12, 11));

//TimeSpan daysLate = teste.ReferenceDate - teste.NextPaymentDate;
//bool tradeExpired = daysLate.Days > 30;

//if (tradeExpired)
//  Console.WriteLine( "TradeExpired");
//else
//    Console.WriteLine("oi");

//data for execute testes 
var tradeCategories = new CategoryService(trades).GetCategories();

foreach (var category in tradeCategories)
{
    Console.WriteLine(category);
}
