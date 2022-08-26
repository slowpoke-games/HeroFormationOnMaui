using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class PlayerHeroesSelection : BaseDomainEntity
{
    public HeroClass HeroSlotOne { get; set; }
    public HeroClass HeroSlotTwo { get; set; }
    public HeroClass HeroSlotThree { get; set; }
}