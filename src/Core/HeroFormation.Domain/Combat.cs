using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class Combat : BaseDomainEntity
{
    public CombatLog CombatLog { get; set; }
    public PlayerHeroesSelection PlayerHeroesSelection { get; set; }
    public CombatLocation CombatLocation { get; set; }
    public DateTime CombatStart { get; set; }

}