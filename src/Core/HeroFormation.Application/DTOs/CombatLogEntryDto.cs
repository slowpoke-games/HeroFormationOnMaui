using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class CombatLogEntryDto : BaseDto
{
    public string CombatText { get; set; }
    public DateTime TimeStamp { get; set; }
}