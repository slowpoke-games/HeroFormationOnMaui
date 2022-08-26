using HeroFormation.Application.DTOs.Common;
using HeroFormation.Domain;

namespace HeroFormation.Application.DTOs;

public class PrepareCombatRequestDto : BaseDto
{
    public CombatDto Combat { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime DateRequested { get; set; }
    public string RequestComments { get; set; }
    public DateTime DateActioned { get; set; }
    public bool? Approved { get; set; }
    public bool Cancelled { get; set; }
}