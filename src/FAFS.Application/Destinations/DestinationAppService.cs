using FAFS.Application.Contracts.Destinations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace FAFS.Destinations
{
    public class DestinationAppService :
     CrudAppService<
         Destination, //Entidad
         DestinationDto, //dto de salida
         Guid, //Primary key destination entity
         PagedAndSortedResultRequestDto, //Used for paging/sorting
         CreateUpdateDestinationDto>, //Used to create/update a destination
     IDestinationAppService //implement the IBookAppService
    {
        public DestinationAppService(IRepository<Destination, Guid> repository)
            : base(repository)
        {

        }
    }
}
