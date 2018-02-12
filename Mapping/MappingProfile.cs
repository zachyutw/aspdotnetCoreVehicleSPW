using System.Linq;
using aspdotnetblog.Controllers.Resources;
using aspdotnetblog.Models;
using AutoMapper;
using static aspdotnetblog.Controllers.Resources.VehicleResource;

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
             CreateMap<Vehicle, VehicleResource>()
                .ForMember( vr => vr.Contact, operationObj => operationObj.MapFrom(v => new ContactResource {Name=v.ContactName,Email=v.ContactEmail,Phone=v.ContactPhone}))
                .ForMember( vr => vr.Features, operationObj => operationObj.MapFrom(v => v.Features.Select(vf => vf.FeatureId )));
                

             //API Resource to Domain
             CreateMap<VehicleResource, Vehicle>()
                .ForMember( vehicle => vehicle.ContactName, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Contact.Name))
                .ForMember( vehicle => vehicle.ContactPhone, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Contact.Phone))
                .ForMember( vehicle => vehicle.ContactEmail, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Contact.Email))
                .ForMember( vehicle => vehicle.Features, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Features.Select(id=> new VehicleFeature{FeatureId=id})));

        }
    }
}