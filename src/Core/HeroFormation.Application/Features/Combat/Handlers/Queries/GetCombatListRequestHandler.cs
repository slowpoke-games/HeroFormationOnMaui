using AutoMapper;
using HeroFormation.Application.DTOs.Combat;
using HeroFormation.Application.Features.Combat.Requests.Queries;
using HeroFormation.Application.Persistence.Contracts;
using MediatR;

namespace HeroFormation.Application.Features.Combat.Handlers.Queries;

public class GetCombatListRequestHandler : IRequestHandler<GetCombatListRequest, List<CombatRequestDto>>
{
    private readonly ICombatRequestRepository _combatRepository;
    private readonly IMapper _mapper;

    public GetCombatListRequestHandler(ICombatRequestRepository combatRequestRepository, IMapper mapper)
    {
        _combatRepository = combatRequestRepository;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<List<CombatRequestDto>> Handle(GetCombatListRequest request, CancellationToken cancellationToken)
    {
        var startedCombats = await _combatRepository.GetAllAsync();
        return _mapper.Map<List<CombatRequestDto>>(startedCombats);
    }
}