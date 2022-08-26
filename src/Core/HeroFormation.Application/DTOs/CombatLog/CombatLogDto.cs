using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs.CombatLog;

public class CombatLogDto : BaseDto
{
    public IEnumerable<CombatLogEntryDto> CombatLogEntries { get; set; }
}