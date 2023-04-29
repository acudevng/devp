using System;
using ACU.Portals.Apply.Entities;
using ACU.Portals.Apply.Services.Dtos.Country;
using ACU.Portals.Apply.Services.Dtos.ExtraStudentDetails;
using ACU.Portals.Apply.Services.Interfaces;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ACU.Portals.Apply.Services
{
    public class ExtraStudentDetailsAppService : CrudAppService<ExtraStudentDetails, ExtraStudentDetailsDto, long, PagedResultRequestDto, CreateUpdateExtraStudentDetailsDto,
        CreateUpdateExtraStudentDetailsDto>
    {
        public ExtraStudentDetailsAppService(IRepository<ExtraStudentDetails, long> repository) : base(repository)
        {

        }
    }
}

