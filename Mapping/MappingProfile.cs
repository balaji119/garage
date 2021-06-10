using AutoMapper;
using garage.Controllers;
using garage.Controllers.Resources;

namespace garage.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
        }
        
    }
}