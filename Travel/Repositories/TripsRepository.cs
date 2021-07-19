using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Travel.Models;

namespace Travel.Repositories
{
  public class TripsRepository
  {
    private readonly IDbConnection _db;

    public TripsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal List<Trip> GetTrips()
    {
      string sql = "SELECT * FROM trips;";
      return _db.Query<Trip>(sql).ToList();
    }
    internal Trip GetTripById(int id)
    {
      string sql = "SELECT * FROM trips WHERE id = @Id";
      return _db.QueryFirstOrDefault<Trip>(sql, new { id });
    }
    internal Trip CreateTrip(Trip trip)
    {
      string sql = "INSERT INTO trips(descript, flightTime, price) VALUES (@Description, @FlightTime, @Price); SELECT LAST_INSERT_ID();";
      trip.Id = _db.ExecuteScalar<int>(sql, trip);
      return trip;
    }


  }
}