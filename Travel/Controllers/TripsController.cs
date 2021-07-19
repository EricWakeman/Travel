using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using Travel.Services;

namespace Travel.Controllers
{
  [ApiController]
  [Route("api/[Controller]")]
  public class TripsController : ControllerBase
  {
    private readonly TripsService _ts;

    public TripsController(TripsService ts)
    {
      _ts = ts;
    }
    [HttpGet]

    public ActionResult<List<Trip>> GetAllTrips()
    {
      try
      {
        return Ok(_ts.GetTrips());
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Trip> GetTripById(int id)
    {
      try
      {
        return Ok(_ts.GetTripById(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPost]
    [Authorize]
    public async Task<ActionResult<Trip>> CreateTrip([FromBody] Trip trip)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        trip.CreatorId = userInfo.Id;
        return Ok(_ts.CreateTrip(trip));

      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }


  }
}