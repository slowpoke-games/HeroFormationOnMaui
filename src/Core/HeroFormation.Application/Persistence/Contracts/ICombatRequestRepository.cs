using HeroFormation.Domain;

namespace HeroFormation.Application.Persistence.Contracts;

public interface ICombatRequestRepository : IGenericRepository<CombatRequest>
{
    Task<CombatRequest> GetCombatRequestWithDetailsAsync(int id);
}