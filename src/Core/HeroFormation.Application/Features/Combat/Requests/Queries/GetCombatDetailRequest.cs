using HeroFormation.Application.DTOs.Combat;
using MediatR;

namespace HeroFormation.Application.Features.Combat.Requests.Queries;

public class GetCombatDetailRequest : IRequest<CombatDto>
{
    public int Id { get; set; }
}