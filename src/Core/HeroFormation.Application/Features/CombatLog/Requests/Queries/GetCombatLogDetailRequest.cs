using HeroFormation.Application.DTOs.CombatLog;
using MediatR;

namespace HeroFormation.Application.Features.CombatLog.Requests.Queries;

public class GetCombatLogDetailRequest : IRequest<CombatLogDto>
{
    public int Id { get; set; }
}