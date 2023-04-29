using System;
namespace ACU.Portals.Apply.Services.Dtos.AcademicDetails
{
	public class CreateUpdateAcademicDetailsDto
	{
        public string? EducationalQualification { get; set; }
        public string? Institution { get; set; }
        public long? StudentDetailsId { get; set; }
    }
}

