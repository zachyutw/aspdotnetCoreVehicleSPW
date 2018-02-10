using aspdotnetblog.Controllers.Resources;
using aspdotnetblog.Models;
using AutoMapper;
namespace aspdotnetblog.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
             CreateMap<Model, ModelResource>();
        }
    }
}