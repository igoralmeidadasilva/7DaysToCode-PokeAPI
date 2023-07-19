using System;
using AutoMapper;
using model;

namespace utils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Pokemon, Mascote>();    
        }
    }
}
