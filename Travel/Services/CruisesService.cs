using System.Collections.Generic;
using Travel.Models;
using Travel.Repositories;

namespace Travel.Services
{
  public class CruisesService
  {
    private readonly CruisesRepository _cr;

    public CruisesService(CruisesRepository cr)
    {
      _cr = cr;
    }

    public List<Cruise> GetCruises()
    {
      return _cr.GetCruises();
    }
    public Cruise GetCruiseById(int id)
    {
      return _cr.GetCruiseById(id);
    }
    public Cruise CreateCruise(Cruise CruiseData)
    {
      return _cr.CreateCruise(CruiseData);
    }

  }
}