using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class HeroClass : BaseDomainEntity
{
    public string Name { get; set; }
    public HeroType HeroType { get; set; }
}