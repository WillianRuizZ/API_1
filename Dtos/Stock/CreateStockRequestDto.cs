namespace API_1.Interfaces.Dtos.Stock;

public class CreateStockRequestDto
{
    public string Symbol { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public decimal Purchase { get; set; } // Propiedad para el precio de compra
    public decimal LastDiv { get; set; } // Último dividendo

    public string Industry { get; set; } = string.Empty;
    public long MarketCap { get; set; }
}
