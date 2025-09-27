using AutoMapper;
using FAFS.Destinations;                         // Entidad
using FAFS.Application.Contracts.Destinations;  // DTOs

namespace FAFS
{
    public class DestinationApplicationAutoMapperProfile : Profile
    {
        public DestinationApplicationAutoMapperProfile()
        {
            // Mapear de entidad a DTO
            CreateMap<Destination, DestinationDto>()
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Coordinates.Latitude))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Coordinates.Longitude));

            // Mapear de CreateDestinationDto a entidad 
            CreateMap<CreateDestinationDto, Destination>()
                .ForMember(dest => dest.Coordinates,
                           opt => opt.MapFrom(src => new Coordinates(src.Latitude ?? "", src.Longitude ?? "")));
        }
    }
}