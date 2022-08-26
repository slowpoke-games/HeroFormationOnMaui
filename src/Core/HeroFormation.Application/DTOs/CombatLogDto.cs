using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class CombatLogDto : BaseDto
{
    public IEnumerable<CombatLogEntryDto> CombatLogEntries { get; set; }
}