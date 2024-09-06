namespace Application.Dtos;

public record ChampionDamageRequestDto {
    public required int ChampionId { get; init; }
    public required int Level { get; init; }
    public required SkillLevels SkillLevels { get; init; }
}