using Domain.Entities;
using Domain.Enums;

namespace Domain;

public static class MockChampions {
    public static Champion Lux = new() {
        ChampionId = 1,
        Name = ChampionName.Lux,
        Level = 7,
        BaseHp = 580,
        Ad = 54,
        TotalAd = 0,
        Ap = 0,
        Armor = 21,
        MagicResist = 30,
        CriticalChance = 0,
        Lethality = 0,
        FlatMagicPen = 0,
        ArmorPen = 0,
        MagicPen = 0,
        CriticalDamage = 0,
        PerLevelAd = 3.3,
        PerLevelArmor = 5.2,
        PerLevelMagicResistance = 1.3,
        PerLevelHealth = 99,
        PerLevelMana = 23.5,
        Passive = new Passive(),
        SkillQ = new Skill {
            SkillId = Guid.NewGuid(),
            Description = "Q LUX",
            SkillLevel = 1,
            BaseDamagePerLevel = 40,
            BaseDamage = 80,
            SkillType = SkillType.Magical,
            BaseAdScaling = 0,
            BaseApScaling = 0.65,
            ApScalingPerLevel = 0,
            AdScalingPerLevel = 0,
            HpScaling = 0,
            MpScaling = 0,
        },
        SkillW = new Skill {
            SkillId = Guid.NewGuid(),
            Description = "W LUX",
            SkillLevel = 1,
            BaseDamage = 80,
            BaseDamagePerLevel = 15,
            SkillType = SkillType.Shield,
            BaseAdScaling = 0,
            BaseApScaling = 0.8,
            ApScalingPerLevel = 0,
            AdScalingPerLevel = 0,
            HpScaling = 0,
            MpScaling = 0
        },
        SkillE = new Skill {
            SkillId = Guid.NewGuid(),
            Description = "LUX E",
            SkillLevel = 4,
            BaseDamage = 65,
            BaseDamagePerLevel = 50,
            SkillType = SkillType.Magical,
            BaseAdScaling = 0,
            BaseApScaling = 0.8,
            ApScalingPerLevel = 0,
            AdScalingPerLevel = 0,
            HpScaling = 0,
            MpScaling = 0
        },
        SkillR = new Skill {
            SkillId = Guid.NewGuid(),
            Description = "LUX R",
            SkillLevel = 1,
            BaseDamage = 300,
            BaseDamagePerLevel = 100,
            SkillType = SkillType.Magical,
            BaseAdScaling = 0,
            BaseApScaling = 1.2,
            ApScalingPerLevel = 0,
            AdScalingPerLevel = 0,
            HpScaling = 0,
            MpScaling = 0
        }
    };

}