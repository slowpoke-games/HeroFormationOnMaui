using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class CombatLocation : BaseDomainEntity
{
    public string Name { get; set; }

    public IEnumerable<CombatStage> CombatStages { get; set; }
    public CombatRegion CombatRegion { get; set; }
}