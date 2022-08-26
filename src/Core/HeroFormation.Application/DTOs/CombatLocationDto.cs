using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class CombatLocationDto : BaseDto
{
    public string Name { get; set; }

    public IEnumerable<CombatStageDto> CombatStages { get; set; }
}