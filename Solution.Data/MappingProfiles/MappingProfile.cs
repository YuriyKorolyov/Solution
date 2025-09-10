using AutoMapper;
using Solution.Data.Dto;
using Solution.Domain;

namespace Solution.Data.MappingProfiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserDto, User>().ReverseMap();
    }
}
