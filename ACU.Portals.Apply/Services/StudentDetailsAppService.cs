using System;
using ACU.Portals.Apply.Entities;
using ACU.Portals.Apply.Services.Dtos.StudentApplication;
using ACU.Portals.Apply.Services.Dtos.StudentDetails;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ACU.Portals.Apply.Services
{
    public class StudentDetailsAppService : CrudAppService<StudentDetails, StudentDetailsDto, long, PagedResultRequestDto, CreateUpdateStudentDetailsDto,
        CreateUpdateStudentApplicationDto>
    {
        public StudentDetailsAppService(IRepository<StudentDetails, long> repository) : base(repository)
        {

        }
    }
}

