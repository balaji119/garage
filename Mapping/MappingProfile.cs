using AutoMapper;
using garage.Models;
using garage.Models.Resources;

namespace garage.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Model, ModelResource>();
            CreateMap<Make, MakeResource>();
        }
    }
}