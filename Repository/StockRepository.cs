using API_1.Data;
using API_1.Interfaces;
using API_1.Models;
using Microsoft.EntityFrameworkCore;

namespace API_1.Repository;

public class StockRepository : IStockRepository
{
    private readonly ApplicationDBContext _context;
    public StockRepository(ApplicationDBContext context){
      _context=context;
    }
     public Task<List<Stock>> GetAllAsync()
    {
       return _context.Stocks.ToListAsync();
    }
}
