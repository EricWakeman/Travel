using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Travel.Models;

namespace Travel.Repositories
{
  public class CruisesRepository
  {
    private readonly IDbConnection _db;

    public CruisesRepository(IDbConnection db)
    {
      _db = db;
    }
    internal List<Cruise> GetCruises()
    {
      string sql = "SELECT * FROM cruises;";
      return _db.Query<Cruise>(sql).ToList();
    }
    internal Cruise GetCruiseById(int id)
    {
      string sql = "SELECT * FROM cruises WHERE id = @Id";
      return _db.QueryFirstOrDefault<Cruise>(sql, new { id });
    }
    internal Cruise CreateCruise(Cruise cruise)
    {
      string sql = "INSERT INTO cruises(descript, shipSize, price) VALUES (@Description, @ShipSize, @Price); SELECT LAST_INSERT_ID();";
      cruise.Id = _db.ExecuteScalar<int>(sql, cruise);
      return cruise;
    }


  }
}