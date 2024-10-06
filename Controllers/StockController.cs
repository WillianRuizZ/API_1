
using API_1.Dtos.Stock;
using API_1.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace API_1.Data;

[Route("api/stock")]
[ApiController]
public class StockController : ControllerBase
{
    private readonly ApplicationDBContext _context;

    public StockController(ApplicationDBContext context)
    {
        _context = context; // Asignar el contexto aquí
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var stocks = _context.Stocks.ToList()
            .Select(stock => stock.ToStockDto()); // Ahora esto no debería lanzar NullReferenceException

        return Ok(stocks);
    }

    [HttpGet("{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var stock = _context.Stocks.Find(id);
        if (stock == null)
        {
            return NotFound();
        }
        return Ok(stock);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateStockRequestDto stockDto)
    {
        var stock = stockDto.ToStockFromCreateDto();
        _context.Stocks.Add(stock);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetById), new { id = stock.Id }, stock.ToStockDto());
    }

    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] UpdateStockRequestDto stockDto)
    {
        var stock = _context.Stocks.FirstOrDefault(x => x.Id == id);
        if (stock == null)
        {
            return NotFound();
        }
        stock.Symbol = stockDto.Symbol;
        stock.CompanyName = stockDto.CompanyName;
        stock.Purchase = stockDto.Purchase;
        stock.LastDiv = stockDto.LastDiv;
        stock.Industry = stockDto.Industry;
        stock.MarketCap = stockDto.MarketCap;
        _context.SaveChanges();
        return Ok(stock.ToStockDto());
    }

    [HttpDelete("{id}")]
    public IActionResult Delete([FromRoute] int id)
    {
        var stock = _context.Stocks.FirstOrDefault(x => x.Id == id);
        if (stock == null)
        {
            return NotFound();
        }
        _context.Stocks.Remove(stock);
        _context.SaveChanges();
        return NoContent();
    }
}




