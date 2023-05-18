using api_effects.Data.Dtos;
using api_effects.Models;
using AutoMapper;

namespace api_effects.Profiles
{
    public class RegistroProfile : Profile
    {
        public RegistroProfile() 
        {
            CreateMap<CreateRegistroDto, Registro>();
            CreateMap<UpdateRegistroDto, Registro>();
        }
    }
}
