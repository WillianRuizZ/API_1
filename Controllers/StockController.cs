using Microsoft.AspNetCore.Mvc;


namespace API_1.Data;
[Route("api/stock")]
[ApiController]
public class StockController : ControllerBase
{
  private readonly ApplicationDBContext _context;
  public StockController(ApplicationDBContext context)
  {
  }

  [HttpGet]
  public IActionResult GetAll()
  {
    var stocks = _context.Stocks.ToList();
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

}
