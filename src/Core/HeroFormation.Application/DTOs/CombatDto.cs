using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class CombatDto : BaseDto
{
    public CombatLogDto CombatLog { get; set; }
    public PlayerHeroesSelectionDto PlayerHeroesSelection { get; set; }
    public CombatLocationDto CombatLocation { get; set; }
    public DateTime CombatStart { get; set; }
}