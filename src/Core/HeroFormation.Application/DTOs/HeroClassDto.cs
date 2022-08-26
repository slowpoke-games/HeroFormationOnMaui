using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class HeroClassDto : BaseDto
{
    public string Name { get; set; }
    public HeroTypeDto HeroType { get; set; }
}