using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class CombatStage : BaseDomainEntity
{
    public int StageNumber { get; set; }
    public bool IsSpecialStage { get; set; }
}