using System.Collections.Generic;
using System.Linq;
using aspdotnetblog.Controllers.Resources;
using aspdotnetblog.Models;
using AutoMapper;
using static aspdotnetblog.Controllers.Resources.SaveVehicleResource;

namespace aspdotnetblog.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to API Resource
            CreateMap<Make, MakeResource>();
             CreateMap<Make, KeyValuePairResource>();
             CreateMap<Feature, KeyValuePairResource>();
             CreateMap<Vehicle, SaveVehicleResource>()
                .ForMember( vr => vr.Contact, operationObj => operationObj.MapFrom(v => new ContactResource {Name=v.ContactName,Email=v.ContactEmail,Phone=v.ContactPhone}))
                .ForMember( vr => vr.Features, operationObj => operationObj.MapFrom(v => v.Features.Select(vf => vf.FeatureId )));
            CreateMap<Vehicle, VehicleResource>()
                .ForMember( vr => vr.Contact, operationObj => operationObj.MapFrom(v => new ContactResource {Name=v.ContactName,Email=v.ContactEmail,Phone=v.ContactPhone}))
                .ForMember( vr => vr.Features, operationObj => operationObj.MapFrom(v => v.Features.Select(vf => new KeyValuePairResource{ Id = vf.Feature.Id, Name = vf.Feature.Name} )))
                .ForMember( vr => vr.Make, opt => opt.MapFrom( v => v.Model.Make ));
             //API Resource to Domain
             CreateMap<SaveVehicleResource, Vehicle>()
                .ForMember( v => v.Id, opt => opt.Ignore())
                .ForMember( vehicle => vehicle.ContactName, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Contact.Name))
                .ForMember( vehicle => vehicle.ContactPhone, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Contact.Phone))
                .ForMember( vehicle => vehicle.ContactEmail, operationObj => operationObj.MapFrom(vehicleResource => vehicleResource.Contact.Email))
                .ForMember( vehicle => vehicle.Features, operationObj => operationObj.Ignore())
                .AfterMap( (vr,v) => {
                    /* Solve Duplicate */
                    //Remove uselected Feautres

                    /* Use LinQ */

                    // var removeFeatures = new List<VehicleFeature>();
                    // foreach(var f in v.Features){
                    //     if(vr.Features.Contains(f.FeatureId)){
                    //     removeFeatures.Add(f);}
                    // }

                    var removeFeatures = v.Features.Where(f=>!vr.Features.Contains(f.FeatureId));
                    foreach(var f in removeFeatures){
                        v.Features.Remove(f);
                    }
                    // Add new Feautre
                    // foreach(var id in vr.Features){
                    //     if(v.Features.Any(f=>f.FeatureId==id)){
                    //         v.Features.Add(new VehicleFeature {FeatureId=id});

                    //     }
                    // }

                   var addedFeatures = vr.Features.Where(id => !v.Features.Any(f => f.FeatureId ==id)).Select(id => new VehicleFeature{ FeatureId=id});
                   foreach(var f in addedFeatures){
                        v.Features.Add(f);
                   }
                } );

        }
    }
}