using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAFS.Destinations
{
    public class GeoDbCitySearchService : ICitySearchService
    {
        public Task<CitySearchResultDto> SearchCitiesAsync(CitySearchRequestDto request)
        {
            // Simulate a call to an external geolocation database or API
            var cities = new List<CityDto>
            {
                new CityDto { City = "New York", Country = "USA" },
                new CityDto { City = "Newark", Country = "USA" },
                new CityDto { City = "New Delhi", Country = "India" },
                new CityDto { City = "Newcastle", Country = "UK" }
            };
            var matchingCities = cities
                .Where(c => c.City.StartsWith(request.PartialName, StringComparison.OrdinalIgnoreCase))
                .ToList();
            var result = new CitySearchResultDto
            {
                Cities = matchingCities
            };
            return Task.FromResult(result);
        }
    }
}
