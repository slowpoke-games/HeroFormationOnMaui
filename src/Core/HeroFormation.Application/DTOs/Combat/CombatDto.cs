using HeroFormation.Application.DTOs.CombatLog;
using HeroFormation.Application.DTOs.Common;
using HeroFormation.Domain;

namespace HeroFormation.Application.DTOs.Combat;

public class CombatDto : BaseDto
{
    public CombatLogDto CombatLog { get; set; }
    public PlayerHeroesSelectionDto PlayerHeroesSelection { get; set; }
    public CombatLocationDto CombatLocation { get; set; }
    public DateTime CombatStart { get; set; }
    public CombatState CombatState { get; set; }
}