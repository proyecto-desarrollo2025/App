using FAFS.Application.Contracts.Destinations;  // DTOs
using FAFS.Destinations;                         // Entidad y ValueObject
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace FAFS.Application.Destinations
{
    public class DestinationAppService : ApplicationService
    {
        private readonly IRepository<Destination, int> _destinationRepository;

        public DestinationAppService(IRepository<Destination, int> destinationRepository)
        {
            _destinationRepository = destinationRepository;
        }

        // 👇 Este es el método con las validaciones
        public async Task<DestinationDto> CreateAsync(CreateDestinationDto input)
        {
            // ✅ Validaciones básicas
            if (string.IsNullOrWhiteSpace(input.Name))
            {
                throw new BusinessException("El nombre del destino es obligatorio.");
            }

            if (input.Name.Length > 200)
            {
                throw new BusinessException("El nombre del destino no puede superar los 200 caracteres.");
            }

            if (!string.IsNullOrWhiteSpace(input.Country) && input.Country.Length > 100)
            {
                throw new BusinessException("El país no puede superar los 100 caracteres.");
            }

            if (!string.IsNullOrWhiteSpace(input.City) && input.City.Length > 100)
            {
                throw new BusinessException("La ciudad no puede superar los 100 caracteres.");
            }

            if (!string.IsNullOrWhiteSpace(input.PhotoUrl) && input.PhotoUrl.Length > 300)
            {
                throw new BusinessException("La URL de la foto no puede superar los 300 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(input.Latitude) || string.IsNullOrWhiteSpace(input.Longitude))
            {
                throw new BusinessException("Las coordenadas (latitud y longitud) son obligatorias.");
            }

            // ✅ Crear entidad
            var destination = new Destination(
                id: 0,
                name: input.Name,
                country: input.Country ?? string.Empty,
                city: input.City ?? string.Empty,
                photoUrl: input.PhotoUrl ?? string.Empty,
                lastUpdated: DateTime.Now,
                coordinates: new Coordinates(input.Latitude, input.Longitude)
            );

            // ✅ Guardar en BD usando la variable correcta
            var savedEntity = await _destinationRepository.InsertAsync(destination, autoSave: true);

            // ✅ Mapear a DTO de salida
            return ObjectMapper.Map<Destination, DestinationDto>(savedEntity);
        }
    }
}


