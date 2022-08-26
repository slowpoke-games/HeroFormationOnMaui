using HeroFormation.Domain;

namespace HeroFormation.Application.Persistence.Contracts;

public interface ICombatLogRequestRepository : IGenericRepository<CombatLogRequest>
{
    Task<CombatLogRequest> GetCombatLogRequestWithEntriesAsync(int id);
}