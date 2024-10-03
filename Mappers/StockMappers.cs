
using API_1.Dtos.Stock;
using API_1.Models;

namespace API_1.Mappers;

public static class StockMappers
{
  public static StocksDto ToStockDto(this Stock stockModel)
  {
    return new StocksDto
    {
     Id = stockModel.Id,
     Symbol = stockModel.Symbol,
     CompanyName = stockModel.CompanyName,
     Purchase = stockModel.Purchase,
     LastDiv = stockModel.LastDiv,
     Industry = stockModel.Industry,
     MarketCap = stockModel.MarketCap
    };
  }

  public static Stock ToStockFromCreateDto(this CreateStockRequestDto stockDto){
    return new Stock
    {
      Symbol = stockDto.Symbol,
      CompanyName = stockDto.CompanyName,
      Purchase = stockDto.Purchase,
      LastDiv = stockDto.LastDiv,
      Industry = stockDto.Industry,
      MarketCap = stockDto.MarketCap
    };
  }
}
