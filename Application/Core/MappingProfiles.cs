using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;

namespace API.Core
{
    public class MappingProfiles : Profile
    {
        protected MappingProfiles()
        {
            CreateMap<Activity, Activity>();
        }
    }
}