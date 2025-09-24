using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace FAFS.Destinations
{
    public class Destination : AuditedAggregateRoot<int>
    {
        public string Name { get; private set; } = string.Empty;
        public string Country { get; private set; } = string.Empty;
        public string City { get; private set; } = string.Empty;
        public string PhotoUrl { get; private set; } = string.Empty;
        public Coordinates Coordinates { get; private set; } = new Coordinates(string.Empty, string.Empty);
        public DateTime LastUpdated { get; private set; } = DateTime.Now;

        // ValueObject
        protected Destination() { } // Requerido por EF
        public Destination(
            int id,
            string name,
            string country,
            string city,
            string photoUrl,
            DateTime lastUpdated,
            Coordinates coordinates
        ) : base(id)
        {
            Name = name;
            Country = country;
            City = city;
            PhotoUrl = photoUrl;
            LastUpdated = lastUpdated;
            Coordinates = coordinates;
        }
    }
    // Value Object
    public class Coordinates
    {
        public string Latitude { get; private set; } = string.Empty;
        public string Longitude { get; private set; } = string.Empty;
        protected Coordinates() { } // EF necesita constructor sin parámetros
        public Coordinates(string latitude, string longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}

