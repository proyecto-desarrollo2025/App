using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Application.Dtos;


namespace FAFS.Application.Contracts.Destinations
{
    public class CreateUpdateDestinationDto : AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Country { get; set; }

        [StringLength(100)]
        public string? City { get; set; }

        [StringLength(300)]
        public string? PhotoUrl { get; set; }

        public string? Latitude { get; set; }
        public string? Longitude { get; set; }
    }
}