using Domain.Entities;
using Domain.Enums;

namespace Domain;

public static class MockChampions
{
    public static Champion Lux = new(
        new Skill
        {
            SkillId = Guid.NewGuid(),
            ChampionId = 61,
            Description = "Q LUX",
            SkillLevel = 1,
            BaseDamagePerLevel = 0,
            BaseDamagePerSkillLevel = 40,
            BaseDamage = 80,
            SkillType = SkillType.Magical,
            BaseAdScaling = 0,
            BaseApScaling = 0.65,
            ApScalingPerSkillLevel = 0,
            AdScalingPerSkillLevel = 0,
            HpScaling = 0,
            MpScaling = 0,
        },
        new Skill
        {
            SkillId = Guid.NewGuid(),
            ChampionId = 61,
            Description = "W LUX",
            SkillLevel = 1,
            BaseDamage = 80,
            BaseDamagePerLevel = 0,
            BaseDamagePerSkillLevel = 15,
            SkillType = SkillType.Shield,
            BaseAdScaling = 0,
            BaseApScaling = 0.8,
            ApScalingPerSkillLevel = 0,
            AdScalingPerSkillLevel = 0,
            HpScaling = 0,
            MpScaling = 0
        },
        new Skill
        {
            SkillId = Guid.NewGuid(),
            ChampionId = 61,
            Description = "LUX E",
            SkillLevel = 4,
            BaseDamage = 65,
            BaseDamagePerLevel = 0,
            BaseDamagePerSkillLevel = 50,
            SkillType = SkillType.Magical,
            BaseAdScaling = 0,
            BaseApScaling = 0.8,
            ApScalingPerSkillLevel = 0,
            AdScalingPerSkillLevel = 0,
            HpScaling = 0,
            MpScaling = 0
        },
        new Skill
        {
            SkillId = Guid.NewGuid(),
            ChampionId = 61,
            Description = "LUX R",
            SkillLevel = 1,
            BaseDamage = 300,
            BaseDamagePerLevel = 0,
            BaseDamagePerSkillLevel = 100,
            SkillType = SkillType.Magical,
            BaseAdScaling = 0,
            BaseApScaling = 1.2,
            ApScalingPerSkillLevel = 0,
            AdScalingPerSkillLevel = 0,
            HpScaling = 0,
            MpScaling = 0
        })
    {
        ChampionId = 61,
        Name = ChampionName.Lux,
        Level = 7,
        Health = 580,
        Mana = 480,
        Ad = 54,
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
        Passive = new Passive()
    };

}