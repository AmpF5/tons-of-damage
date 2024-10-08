using Application.Dtos;
using FluentValidation;

namespace Application.Validators;

public class SkillLevelsValidator : AbstractValidator<SkillLevels>
{
    public SkillLevelsValidator()
    {
        RuleFor(x => x.SkillQ)
            .InclusiveBetween(0, 5)
            .WithMessage("Q skill level must be between 0 and 5");

        RuleFor(x => x.SkillW)
            .InclusiveBetween(0, 5)
            .WithMessage("W skill level must be between 0 and 5");

        RuleFor(x => x.SkillE)
            .InclusiveBetween(0, 5)
            .WithMessage("E skill level must be between 0 and 5");

        RuleFor(x => x.SkillR)
            .InclusiveBetween(0, 3)
            .WithMessage("R skill level must be between 0 and 3");
    }
}