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
  public class CruisesController : ControllerBase
  {
    private readonly CruisesService _cs;

    public CruisesController(CruisesService cs)
    {
      _cs = cs;
    }
    [HttpGet]
    public ActionResult<List<Cruise>> GetAllCruises()
    {
      try
      {
        return Ok(_cs.GetCruises());
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")]
    public ActionResult<Cruise> GetCruiseById(int id)
    {
      try
      {
        return Ok(_cs.GetCruiseById(id));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [Authorize]
    [HttpPost]
    public async Task<ActionResult<Cruise>> CreateCruise([FromBody] Cruise cruise)
    {
      try
      {
        Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
        cruise.CreatorId = userInfo.Id;
        return Ok(_cs.CreateCruise(cruise));
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}