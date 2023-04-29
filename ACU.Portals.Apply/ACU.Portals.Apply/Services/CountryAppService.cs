using System;
using ACU.Portals.Apply.Entities;
using ACU.Portals.Apply.Services.Dtos.AddressDetails;
using ACU.Portals.Apply.Services.Dtos.ApplicationUpload;
using ACU.Portals.Apply.Services.Dtos.Country;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ACU.Portals.Apply.Services.Interfaces
{
    public class CountryAppService : CrudAppService<Country, CountryDto, long, PagedResultRequestDto, CreateUpdateCountryDto,
        CreateUpdateCountryDto>
    {
        public CountryAppService(IRepository<Country, long> repository) : base(repository)
        {

        }
        
    }
}

