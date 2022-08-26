using AutoMapper;
using HeroFormation.Application.DTOs.Combat;
using HeroFormation.Application.DTOs.CombatLog;
using HeroFormation.Domain;

namespace HeroFormation.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CombatRequest, CombatRequestDto>().ReverseMap();
        CreateMap<CombatLogRequest, CombatLogRequestDto>().ReverseMap();
    }
}