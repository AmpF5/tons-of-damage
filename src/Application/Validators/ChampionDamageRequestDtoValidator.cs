using Application.Dtos;
using FluentValidation;

namespace Application.Validators;

public class ChampionDamageRequestDtoValidator : AbstractValidator<ChampionDamageRequestDto> {
    public ChampionDamageRequestDtoValidator() {
        RuleFor(x => x.Level)
            .InclusiveBetween(1, 18)
            .WithMessage("Level must be between 1 and 18");

        RuleFor(x => x.SkillLevels)
            .SetValidator(new SkillLevelsValidator());
    }
}