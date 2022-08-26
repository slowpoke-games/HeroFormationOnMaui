using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class CombatLog : BaseDomainEntity
{
    public IEnumerable<CombatLogEntry> CombatLogEntries { get; set; }
}