using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroFormation.Domain;

namespace HeroFormation.Application.Persistence.Contracts
{
    public interface IPrepareCombatRequestRepository : IGenericRepository<PrepareCombatRequest>
    {
    }
}
