using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class CombatRegion : BaseDomainEntity
{
    public string Name { get; set; }
    public float DifficultyLevel { get; set; }
}