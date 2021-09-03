using AutoMapper;
using Domain.Entities;
using Infrastructure.Persistance;

namespace Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<SignLanguageDTO, SignLanguage>().ReverseMap();
        }
    }
}
