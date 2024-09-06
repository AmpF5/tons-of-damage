using Domain.Enums;

namespace Domain.Entities;

public class Skill {
    public required Guid SkillId { get; set; }
    public required string Description { get; set; } 
    public required int SkillLevel { get; set; }
    public required int BaseDamage { get; set; }
    //@TODO Probably to change if damage increase is not linear
    public required int BaseDamagePerLevel { get; set; }
    public required SkillType SkillType { get; set; }
    
    public required double BaseAdScaling { get; set; }
    public required double BaseApScaling { get; set; }
    public required double ApScalingPerLevel { get; set; }
    public required double AdScalingPerLevel { get; set; }
    public required double HpScaling { get; set; }
    public required double MpScaling { get; set; }
}