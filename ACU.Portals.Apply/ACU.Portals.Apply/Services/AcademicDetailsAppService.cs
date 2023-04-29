using System;
using ACU.Portals.Apply.Entities;
using ACU.Portals.Apply.Services.Dtos.AcademicDetails;
using ACU.Portals.Apply.Services.Interfaces;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ACU.Portals.Apply.Services
{
	public class AcademicDetailsAppService:CrudAppService<AcademicDetails,AcademicDetailsDto,long,PagedResultRequestDto,CreateUpdateAcademicDetailsDto,
        CreateUpdateAcademicDetailsDto>
    {
        private readonly IRepository<AcademicDetails, long> _repository;

        public AcademicDetailsAppService(IRepository<AcademicDetails, long> repository):base(repository)
        {
            _repository = repository;
        }

        
    }
}

