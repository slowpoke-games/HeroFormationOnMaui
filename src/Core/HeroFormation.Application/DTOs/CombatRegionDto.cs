using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class CombatRegionDto : BaseDto
{
    public string Name { get; set; }

    public IEnumerable<CombatLocationDto> CombatLocations { get; set; }
}