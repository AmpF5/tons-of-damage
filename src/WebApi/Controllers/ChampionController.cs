using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionController : ControllerBase
    {
        [HttpGet("{championId}")]
        public float GetChampionDamage([FromRoute]int championId)
        {
            return 13.37f;
        }
    }
}
