using System;
using ACU.Portals.Apply.Entities;
using ACU.Portals.Apply.Services.Dtos.AcademicDetails;
using ACU.Portals.Apply.Services.Dtos.AddressDetails;
using ACU.Portals.Apply.Services.Interfaces;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ACU.Portals.Apply.Services
{
    public class AddressDetailsAppService : CrudAppService<AddressDetails, AddressDetailsDto, long, PagedResultRequestDto, CreateUpdateAddressDetailsDto,
        CreateUpdateAddressDetailsDto>
    {
        public AddressDetailsAppService(IRepository<AddressDetails, long> repository) : base(repository)
        {

        }
    }
}

