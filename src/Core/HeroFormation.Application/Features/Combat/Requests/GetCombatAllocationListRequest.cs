using HeroFormation.Application.DTOs;
using MediatR;

namespace HeroFormation.Application.Features.Combat.Requests;

public class GetCombatAllocationListRequest : IRequest<List<CombatAllocationDto>>
{

}