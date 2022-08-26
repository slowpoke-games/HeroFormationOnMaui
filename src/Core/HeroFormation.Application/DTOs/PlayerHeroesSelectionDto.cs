using HeroFormation.Application.DTOs.Common;

namespace HeroFormation.Application.DTOs;

public class PlayerHeroesSelectionDto : BaseDto
{
    public HeroClassDto HeroSlotOne { get; set; }
    public HeroClassDto HeroSlotTwo { get; set; }
    public HeroClassDto HeroSlotThree { get; set; }
}