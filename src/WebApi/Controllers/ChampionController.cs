using Application.Dtos;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionController : ControllerBase
    {
        [HttpGet("damage")]
        public double GetChampionDamage([FromQuery] ChampionDamageRequestDto championDamageRequestDto) {

            return 13.37;
        }
    }
}
