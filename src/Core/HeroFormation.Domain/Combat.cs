using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class Combat : BaseDomainEntity
{
    public CombatLog CombatLog { get; set; }
    public PlayerHeroesSelection PlayerHeroesSelection { get; set; }
    public CombatLocation CombatLocation { get; set; }
    public DateTime CombatStart { get; set; }
    public CombatState CombatState { get; set; }

}

[Flags]
public enum CombatState
{
    None = 0x0,
    Preparing = 0x1,
    Active = 0x2,
    Finished = 0x4,
    ApplicationError = 0x8,
    Cancelled = 0x16
}