using System.Threading.Tasks;
using Shouldly;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Xunit;
using FAFS.Destinations;
using FAFS.Application.Contracts.Destinations;
using FAFS.Application.Destinations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FAFS.Application.Tests.Destinations
{
    public class DestinationAppService_Tests : FAFSApplicationTestBase
    {
        private readonly DestinationAppService _destinationAppService;
        private readonly IRepository<Destination, int> _destinationRepository;

        public DestinationAppService_Tests()
        {
            _destinationRepository = GetRequiredService<IRepository<Destination, int>>();
            _destinationAppService = GetRequiredService<DestinationAppService>();
        }

        [Fact]
        public async Task Should_Create_Destination_Successfully()
        {
            var input = new CreateDestinationDto
            {
                Name = "Cataratas del Iguazú",
                Country = "Argentina",
                City = "Puerto Iguazú",
                PhotoUrl = "http://example.com/photo.jpg",
                Latitude = "-25.6953",
                Longitude = "-54.4367"
            };

            var result = await _destinationAppService.CreateAsync(input);

            result.ShouldNotBeNull();
            result.Name.ShouldBe("Cataratas del Iguazú");

            var entity = await _destinationRepository.GetAsync(result.Id);
            entity.Name.ShouldBe("Cataratas del Iguazú");
        }
    }
}
