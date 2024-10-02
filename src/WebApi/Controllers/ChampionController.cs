using Application.Dtos;
using Domain;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChampionController(IDamageCalculator damageCalculator) : ControllerBase
{
    private readonly IDamageCalculator _damageCalculator = damageCalculator;

    [HttpGet("damage")]
    public ActionResult<double> GetChampionDamage([FromQuery] ChampionDamageRequestDto championDamageRequestDto)
    {
        var champion = GetChampion(championDamageRequestDto.ChampionId, championDamageRequestDto.Level, championDamageRequestDto.SkillLevels);
        var enemyChampion = GetChampion(championDamageRequestDto.EnemyChampionId, championDamageRequestDto.EnemyLevel, championDamageRequestDto.SkillLevels);

        var damage = _damageCalculator.CalculateDamage(champion, enemyChampion);

        return Ok(damage);
    }

    private Champion GetChampion(int championId, int level, SkillLevels skillLevels)
    {
        var champion = MockChampions.Lux;
        champion.Level = level;
        champion.SkillQ.SkillLevel = skillLevels.SkillQ;
        champion.SkillW.SkillLevel = skillLevels.SkillW;
        champion.SkillE.SkillLevel = skillLevels.SkillE;
        champion.SkillR.SkillLevel = skillLevels.SkillR;

        return champion;
    }
}
