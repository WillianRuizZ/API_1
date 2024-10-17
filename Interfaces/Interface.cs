
using API_1.Models;

namespace API_1.Interfaces;

public interface IStockRepository
{
    Task<List<Stock>> GetAllAsync();
}
