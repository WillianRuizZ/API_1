
using API_1.Interfaces.Dtos.Stock;
using API_1.Models;

namespace API_1.Interfaces;

public interface IStockRepository
{
    Task<List<Stock>> GetAllAsync();

    Task<Stock?> GetByIdAsync(int id);

    Task<Stock> CreateAsync(Stock stockModel);

    Task<Stock?> UpdateAsync(int id,UpdateStockRequestDto stockDto);

    Task<Stock?> DeleteAsync(int id);


}
