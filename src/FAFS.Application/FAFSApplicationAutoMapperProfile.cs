using AutoMapper;
using FAFS.Destinations;                         // Entidad
using FAFS.Application.Contracts.Destinations;  // DTOs

namespace FAFS
{
    public class DestinationApplicationAutoMapperProfile : Profile
    {
        public DestinationApplicationAutoMapperProfile()
        {
            CreateMap<Destination, DestinationDto>()
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Coordinates.Latitude))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Coordinates.Longitude));
            
            CreateMap<CreateUpdateDestinationDto, DestinationDto>()
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Latitude ?? ""))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Longitude ?? ""));
            
        }
    }
}