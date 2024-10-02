using API_1.Models;
using Microsoft.EntityFrameworkCore;

namespace API_1.Data;
public class ApplicationDBContext : DbContext
{
  public ApplicationDBContext(DbContextOptions dbContextOptions)
    : base(dbContextOptions)
  {
  }

  public DbSet<Stock> Stocks { get; set; }

  public DbSet<Comment> Comments { get; set; }


}
