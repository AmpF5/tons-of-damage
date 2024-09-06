using Domain.Enums;

namespace Domain.Entities;

public class Champion {
    public required int ChampionId { get; set; }
    public required ChampionName Name { get; set; }
    public required int Level { get; set; }
    
    public required int BaseHp { get; set; }
    public required int Ad { get; set; }
    public required int TotalAd { get; set; }
    public required int Ap { get; set; }
    public required int Armor { get; set; }
    public required int MagicResist { get; set; }
    public required double CriticalChance { get; set; }
    
    public required int Lethality { get; set; }
    public required int FlatMagicPen { get; set; }
    public required double ArmorPen { get; set; }
    public required double MagicPen { get; set; }
    public required double CriticalDamage { get; set; }

    public required double PerLevelAd { get; set; }
    public required double PerLevelArmor { get; set; }
    public required double PerLevelMagicResistance { get; set; }
    public required double PerLevelHealth { get; set; }
    public required double PerLevelMana { get; set; }

    public required Passive Passive { get; set; }
    public required Skill SkillQ { get; set; }
    public required Skill SkillW { get; set; }
    public required Skill SkillE { get; set; }
    public required Skill SkillR { get; set; }
}