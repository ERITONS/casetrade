//entrepoint .net 6.0 style top-level-templates

using CreditSuisse.TradeCategorizarion.Domain;
using CreditSuisse.TradeCategorizarion.Service;

Trade trade = new Trade();

var trades = trade.GenerateTradeList();

var tradeCategories = new CategoryService(trades).GetCategories();

foreach (var category in tradeCategories)
{
    Console.WriteLine(category);
}
