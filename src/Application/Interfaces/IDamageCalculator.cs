using Domain.Entities;

namespace Domain.Interfaces;

public interface IDamageCalculator
{
    public double CalculateDamage(Champion champion, Champion enemyChampion);
}