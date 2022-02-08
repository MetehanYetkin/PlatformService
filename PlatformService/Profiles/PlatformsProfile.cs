using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Profiles
{
    //Using AutoMapper
    public class PlatformsProfile:Profile
    {
        public PlatformsProfile()
        {
            //Source --> Target 
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformReadDto, Platform>();
            CreateMap<Platform, PlatformCreateDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }

    }
}
