using Application.Dtos;
using Domain.Entities;

namespace Domain.Interfaces;

public interface IDamageCalculator {
    public double CalculateDamage(ChampionDamageRequestDto championDamageRequestDto);
}