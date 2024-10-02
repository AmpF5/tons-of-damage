using Domain.Enums;

namespace Domain.Entities;

public class Champion
{
    public Champion(Skill Q, Skill W, Skill E, Skill R)
    {
        Q.Champion = this;
        W.Champion = this;
        E.Champion = this;
        R.Champion = this;
        SkillQ = Q;
        SkillW = W;
        SkillE = E;
        SkillR = R;
    }

    public required int ChampionId { get; set; }
    public required ChampionName Name { get; set; }
    public required int Level { get; set; }

    public required int Health { get; set; }
    public required int Ad { get; set; }
    public required int Ap { get; set; }
    public required int Armor { get; set; }
    public required int MagicResist { get; set; }
    public required double CriticalChance { get; set; }
    public required int Mana { get; set; }

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

    public double TotalHealth => Health + PerLevelHealth * Level;
    public double TotalMana => Mana + PerLevelMana * Level;
    public double TotalAd => Ad + PerLevelAd * Level;
    public double TotalArmor => Armor + PerLevelArmor * Level;
    public double TotalMagicResist => MagicResist + PerLevelMagicResistance * Level;

    public required Passive Passive { get; set; }
    public /*required*/ Skill SkillQ { get; set; } = null!;
    public /*required*/ Skill SkillW { get; set; } = null!;
    public /*required*/ Skill SkillE { get; set; } = null!;
    public /*required*/ Skill SkillR { get; set; } = null!;
}