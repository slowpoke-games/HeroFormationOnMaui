using AutoMapper;
using HeroFormation.Application.DTOs;
using HeroFormation.Domain;

namespace HeroFormation.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<PrepareCombatRequest, PrepareCombatRequestDto>().ReverseMap();
        CreateMap<CombatAllocation, CombatAllocationDto>().ReverseMap();
    }
}