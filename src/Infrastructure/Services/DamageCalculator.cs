using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;

namespace Infrastructure.Services;

public class DamageCalculator : IDamageCalculator
{
    public double CalculateDamage(Champion champion, Champion enemyChampion)
    {
        var damageResistanceDictionary = CalculateFinalDamageResistanceStat(champion, enemyChampion);
        var damageReductionDictionary = CalculateDamageReductionsFromResistances(damageResistanceDictionary);

        var skills = new Skill[] { champion.SkillQ, champion.SkillW, champion.SkillE, champion.SkillR };
        var finalDamage = skills.Sum(skill => CalculateSkillDamage(skill, damageReductionDictionary));

        return finalDamage;
    }

    private double CalculateSkillDamage(Skill skill, Dictionary<SkillType, double> damageReduction)
    {
        var skillType = skill.SkillType;

        return skillType is not (SkillType.Physical or SkillType.Magical)
            ? 0
            : skill.CalculateFinalDamage(damageReduction[skillType]);
    }

    private Dictionary<SkillType, double> CalculateDamageReductionsFromResistances(Dictionary<SkillType, double> damageResistenceStat)
    {
        var damageReduction = new Dictionary<SkillType, double>();

        foreach (KeyValuePair<SkillType, double> resistance in damageResistenceStat)
        {
            damageReduction[resistance.Key] = CalculateDamageReductionFromResistance(resistance.Value);
        }

        return damageReduction;
    }

    private double CalculateDamageReductionFromResistance(double damageResistenceStat)
    {
        if (damageResistenceStat >= 0)
        {
            return 100 / (100 + damageResistenceStat);
        }
        else
        {
            return 2 - (100 / (100 - damageResistenceStat));
        }
    }

    private Dictionary<SkillType, double> CalculateFinalDamageResistanceStat(Champion champion, Champion enemyChampion)
    {
        return new Dictionary<SkillType, double>
        {
            { SkillType.Physical, CalculateDamageResistance(champion.Lethality, champion.ArmorPen ,enemyChampion.TotalArmor) },
            { SkillType.Magical, CalculateDamageResistance(champion.FlatMagicPen, champion.MagicPen ,enemyChampion.TotalMagicResist) },
            { SkillType.True, 0 }
        };
    }

    private double CalculateDamageResistance(int flatPen, double percentPen, double totalResistance)
    {
        return totalResistance - flatPen - (totalResistance * percentPen);
    }
}