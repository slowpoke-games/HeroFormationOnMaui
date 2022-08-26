using AutoMapper;
using HeroFormation.Application.DTOs.Combat;
using HeroFormation.Application.Features.Combat.Requests.Queries;
using HeroFormation.Application.Persistence.Contracts;
using MediatR;

namespace HeroFormation.Application.Features.Combat.Handlers.Queries;

public class GetCombatDetailRequestHandler : IRequestHandler<GetCombatDetailRequest, CombatDto>
{
    private readonly ICombatRequestRepository _combatRepository;
    private readonly IMapper _mapper;

    public GetCombatDetailRequestHandler(ICombatRequestRepository combatRequestRepository, IMapper mapper)
    {
        _combatRepository = combatRequestRepository;
        _mapper = mapper;
    }
    /// <inheritdoc />
    public async Task<CombatDto> Handle(GetCombatDetailRequest request, CancellationToken cancellationToken)
    {
        var combat = await _combatRepository.GetCombatRequestWithDetailsAsync(request.Id);
        return _mapper.Map<CombatDto>(combat);
    }
}