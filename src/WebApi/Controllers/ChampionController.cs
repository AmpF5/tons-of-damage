using Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionController : ControllerBase
    {
        [HttpGet("damage")]
        public ActionResult<double> GetChampionDamage([FromQuery] ChampionDamageRequestDto championDamageRequestDto) {
            
            return Ok(13.37);
        }
    }
}
