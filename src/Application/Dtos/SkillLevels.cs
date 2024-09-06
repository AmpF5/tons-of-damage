namespace Application.Dtos;

public record SkillLevels {
    public required int SkillQ { get; init; }
    public required int SkillW { get; init; }
    public required int SkillE { get; init; }
    public required int SkillR { get; init; }
}