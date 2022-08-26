using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class CombatLogEntry : BaseDomainEntity
{
    public string CombatText { get; set; }
    public DateTime TimeStamp { get; set; }
}