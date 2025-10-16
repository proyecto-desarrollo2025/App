using FAFS.Destinations;
using Shouldly;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Validation;
using Xunit;
using FAFS.Application.Contracts.Destinations;

namespace FAFS.Application.Tests.Destinations
{
    public abstract class DestinationAppService_Tests : FAFSApplicationTestBase
    {
       private readonly IDestinationAppService _service;

        protected DestinationAppService_Tests()
        {
            _service = GetRequiredService<IDestinationAppService>();
        }

        [Fact]
        public async Task CreateAsync_ShouldReturnCreatedDestinationDto ()
        {
            // Arrange
            var createDto = new CreateUpdateDestinationDto
            {
                Name = "Test Destination",
                Country = "Test Location"
            };
            // Act
            var result = await _service.CreateAsync(createDto);
            // Assert
            result.ShouldNotBeNull();
            result.Id.ShouldNotBe(Guid.Empty);
            result.Name.ShouldBe(createDto.Name);
            result.Country.ShouldBe(createDto.Country);
        }
    }
}


