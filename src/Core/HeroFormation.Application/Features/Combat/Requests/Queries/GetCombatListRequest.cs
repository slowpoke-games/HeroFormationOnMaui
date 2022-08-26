using HeroFormation.Application.DTOs.Combat;
using MediatR;

namespace HeroFormation.Application.Features.Combat.Requests.Queries;

public class GetCombatListRequest : IRequest<List<CombatRequestDto>>
{

}