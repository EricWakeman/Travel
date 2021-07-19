using System;
using Travel.Interfaces;

namespace Travel.Models
{
  public class Trip : Vacation
  {
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }

    public string FlightTime { get; set; }
    public string CreatorId { get; set; }
  }
}