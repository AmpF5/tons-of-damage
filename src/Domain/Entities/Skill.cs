using Domain.Enums;

namespace Domain.Entities;

public class Skill
{
    public required Guid SkillId { get; set; }
    public required int ChampionId { get; set; }
    public /*required*/ Champion Champion { get; set; } = null!;
    public required string Description { get; set; }
    public required int SkillLevel { get; set; }
    public required int BaseDamage { get; set; }
    //@TODO Probably to change if damage increase is not linear
    public required int BaseDamagePerLevel { get; set; }
    public required int BaseDamagePerSkillLevel { get; set; }
    public required SkillType SkillType { get; set; }

    public required double BaseAdScaling { get; set; }
    public required double BaseApScaling { get; set; }
    public required double ApScalingPerSkillLevel { get; set; }
    public required double AdScalingPerSkillLevel { get; set; }
    public required double HpScaling { get; set; }
    public required double MpScaling { get; set; }

    public double CalculateFinalDamage(double damageReduction)
    {
        return CalculateDamage() * damageReduction;
    }

    private double CalculateDamage()
    {
        return CalculateBaseDamage() + CalculateDamageFromAd() + CalculateDamageFromAp() + CalculateDamageFromHealth() + CalculateDamageFromMana();
    }

    private int CalculateBaseDamage()
    {
        return BaseDamage + BaseDamagePerLevel * Champion.Level + BaseDamagePerSkillLevel * SkillLevel;
    }

    private double CalculateDamageFromAd()
    {
        return (BaseAdScaling + AdScalingPerSkillLevel * Champion.Level) * Champion.TotalAd;
    }

    private double CalculateDamageFromAp()
    {
        return (BaseApScaling + ApScalingPerSkillLevel * Champion.Level) * Champion.Ap;
    }

    private double CalculateDamageFromHealth()
    {
        return HpScaling * Champion.TotalHealth;
    }

    private double CalculateDamageFromMana()
    {
        return MpScaling * Champion.TotalMana;
    }
}