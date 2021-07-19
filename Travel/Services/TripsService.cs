using System.Collections.Generic;
using Travel.Models;
using Travel.Repositories;

namespace Travel.Services
{
  public class TripsService
  {
    private readonly TripsRepository _tr;

    public TripsService(TripsRepository tr)
    {
      _tr = tr;
    }

    public List<Trip> GetTrips()
    {
      return _tr.GetTrips();
    }
    public Trip GetTripById(int id)
    {
      return _tr.GetTripById(id);
    }
    public Trip CreateTrip(Trip tripData)
    {
      return _tr.CreateTrip(tripData);
    }

  }
}