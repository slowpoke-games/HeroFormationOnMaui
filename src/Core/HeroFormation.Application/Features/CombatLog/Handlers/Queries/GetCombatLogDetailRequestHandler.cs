using AutoMapper;
using HeroFormation.Application.DTOs.CombatLog;
using HeroFormation.Application.Features.CombatLog.Requests.Queries;
using HeroFormation.Application.Persistence.Contracts;
using MediatR;

namespace HeroFormation.Application.Features.CombatLog.Handlers.Queries;

public class GetCombatLogDetailRequestHandler : IRequestHandler<GetCombatLogDetailRequest, CombatLogDto>
{
    private readonly ICombatLogRequestRepository _combatLogRequestRepository;
    private readonly IMapper _mapper;

    public GetCombatLogDetailRequestHandler(ICombatLogRequestRepository combatLogRequestRepository, IMapper mapper)
    {
        _combatLogRequestRepository = combatLogRequestRepository;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<CombatLogDto> Handle(GetCombatLogDetailRequest request, CancellationToken cancellationToken)
    {
        var combatLog = await _combatLogRequestRepository.GetCombatLogRequestWithEntriesAsync(request.Id);
        return _mapper.Map<CombatLogDto>(combatLog);
    }
}