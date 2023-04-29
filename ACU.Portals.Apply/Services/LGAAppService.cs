using System;
using ACU.Portals.Apply.Entities;
using ACU.Portals.Apply.Services.Dtos.ExtraStudentDetails;
using ACU.Portals.Apply.Services.Dtos.LGA;
using ACU.Portals.Apply.Services.Interfaces;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ACU.Portals.Apply.Services
{
    public class LGAAppService : CrudAppService<LGA, LGADto, long, PagedResultRequestDto, CreateUpdateLGADto,
        CreateUpdateLGADto>
    {
        public LGAAppService(IRepository<LGA, long> repository) : base(repository)
        {

        }
    }
}

