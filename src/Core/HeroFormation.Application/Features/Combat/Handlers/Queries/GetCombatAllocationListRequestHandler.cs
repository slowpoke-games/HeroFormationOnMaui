using AutoMapper;
using HeroFormation.Application.DTOs;
using HeroFormation.Application.Features.Combat.Requests;
using HeroFormation.Application.Persistence.Contracts;
using MediatR;

namespace HeroFormation.Application.Features.Combat.Handlers.Queries;

public class GetCombatAllocationListRequestHandler : IRequestHandler<GetCombatAllocationListRequest, List<CombatAllocationDto>>
{
    private readonly ICombatAllocationRepository _combatAllocationRepository;
    private readonly IMapper _mapper;

    public GetCombatAllocationListRequestHandler(ICombatAllocationRepository combatAllocationRepository, IMapper mapper)
    {
        _combatAllocationRepository = combatAllocationRepository;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<List<CombatAllocationDto>> Handle(GetCombatAllocationListRequest request, CancellationToken cancellationToken)
    {
        var combatAllocations = await _combatAllocationRepository.GetAllAsync();
        return _mapper.Map<List<CombatAllocationDto>>(combatAllocations);
    }
}