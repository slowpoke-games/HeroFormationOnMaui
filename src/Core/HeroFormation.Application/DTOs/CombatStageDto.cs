using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class CombatStageDto : BaseDto
{
    public int StageNumber { get; set; }
    public bool IsSpecialStage { get; set; }
}