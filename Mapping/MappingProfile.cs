using System.Linq;
using aspdotnetblog.Controllers.Resources;
using aspdotnetblog.Models;
using AutoMapper;
namespace aspdotnetblog.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to API Resource
            CreateMap<Make, MakeResource>();
             CreateMap<Model, ModelResource>();
             CreateMap<Feature, FeatureResource>();

             //API Resource to Domain
             CreateMap<VehicleResource, Vehicle>()
                .ForMember( vehicle => vehicle.ContactName, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Contact.Name))
                .ForMember( vehicle => vehicle.ContactPhone, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Contact.Phone))
                .ForMember( vehicle => vehicle.ContactEmail, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Contact.Email))
                .ForMember( vehicle => vehicle.Features, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Features.Select(id=> new VehicleFeature{FeatureId=id})));

        }
    }
}