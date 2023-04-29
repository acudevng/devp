using System;
using ACU.Portals.Apply.Entities;
using ACU.Portals.Apply.Services.Dtos.Country;
using ACU.Portals.Apply.Services.Dtos.CountryState;
using ACU.Portals.Apply.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ACU.Portals.Apply.Services
{
    public class CountryStateAppService : CrudAppService<CountryState, CountryStateDto, long, PagedResultRequestDto, CreateUpdateCountryDto,
        CreateUpdateCountryDto>
    {
        IRepository<CountryState, long> _repository;
        public CountryStateAppService(IRepository<CountryState, long> repository) : base(repository)
        {
            _repository = repository;
        }

        
    }
}

