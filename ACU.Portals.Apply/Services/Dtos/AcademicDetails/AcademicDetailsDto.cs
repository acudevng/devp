using System;
using ACU.Portals.Apply.Entities;
using Volo.Abp.Application.Dtos;

namespace ACU.Portals.Apply.Services.Dtos.AcademicDetails
{
	public class AcademicDetailsDto:EntityDto<long>
	{
        public string? EducationalQualification { get; set; }
        public string? Institution { get; set; }
        public long? StudentDetailsId { get; set; }
        
    }
}

