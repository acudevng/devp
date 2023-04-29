using System;
using ACU.Portals.Apply.Entities;
using ACU.Portals.Apply.Services.Dtos.AddressDetails;
using ACU.Portals.Apply.Services.Dtos.ApplicationUpload;
using ACU.Portals.Apply.Services.Interfaces;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ACU.Portals.Apply.Services
{
    public class ApplicationUploadAppService : CrudAppService<ApplicationUpload, ApplicationUploadDto, long, PagedResultRequestDto, CreateUpdateApplicationUploadDto,
        CreateUpdateAddressDetailsDto>
    {
        public ApplicationUploadAppService(IRepository<ApplicationUpload, long> repository) : base(repository)
        {

        }
    }
}

