using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace API_1.Models;

public class Stock
{
  public int Id { get; set; }
  public string Symbol { get; set; } = string.Empty;
  public string CompanyName { get; set; } = string.Empty;

  [Column(TypeName = "decimal(18,2)")]
  public decimal Purchase { get; set; } // Propiedad para el precio de compra

  [Column(TypeName = "decimal(18,2)")]
  public decimal LastDiv { get; set; } // Último dividendo

  public string Industry { get; set; } = string.Empty;
  public long MarketCap { get; set; }

  // Lista de comentarios (asegúrate de definir la clase 'Comment' también)
  public List<Comment> Comments { get; set; } = [];
}




