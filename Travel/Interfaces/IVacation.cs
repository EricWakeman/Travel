using System;

namespace Travel.Interfaces
{
  public interface Vacation
  {
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string CreatorId { get; set; }
  }
}