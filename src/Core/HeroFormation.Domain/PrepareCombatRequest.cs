using HeroFormation.Domain.Common;

namespace HeroFormation.Domain;

public class PrepareCombatRequest : BaseDomainEntity
{
    public Combat Combat { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DateRequested { get; set; }
    public string RequestComments { get; set; }
    public DateTime DateActioned { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
}