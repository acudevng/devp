using System;
using ACU.Portals.Apply.Entities;
using ACU.Portals.Apply.Services.Dtos.LGA;
using ACU.Portals.Apply.Services.Dtos.StudentApplication;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ACU.Portals.Apply.Services.Interfaces
{
    public class StudentApplicationAppService : CrudAppService<StudentApplication, StudentApplicationDto, long, PagedResultRequestDto, CreateUpdateStudentApplicationDto,
        CreateUpdateStudentApplicationDto>
    {
        public StudentApplicationAppService(IRepository<StudentApplication, long> repository) : base(repository)
        {

        }
    }
}

