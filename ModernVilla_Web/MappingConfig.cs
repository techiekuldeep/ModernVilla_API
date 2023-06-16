using AutoMapper;

using ModernVilla_Web.Models;
using ModernVilla_Web.Models.Dto;

namespace ModernVilla_Web
{
    public class MappingConfig:Profile
    {
        public MappingConfig()
        {
            CreateMap<VillaDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaDTO, VillaUpdateDTO>().ReverseMap();

            CreateMap<VillaNumberDTO, VillaCreateDTO>().ReverseMap();
            CreateMap<VillaNumberDTO, VillaUpdateDTO>().ReverseMap();
        }
    }
}
