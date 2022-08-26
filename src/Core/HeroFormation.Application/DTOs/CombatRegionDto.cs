using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class CombatRegionDto : BaseDto
{
    public string Name { get; set; }
    public float DifficultyLevel { get; set; }
}