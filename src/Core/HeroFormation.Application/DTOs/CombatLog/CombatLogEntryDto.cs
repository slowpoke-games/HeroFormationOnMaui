using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs.CombatLog;

public class CombatLogEntryDto : BaseDto
{
    public string CombatText { get; set; }
    public DateTime TimeStamp { get; set; }
}