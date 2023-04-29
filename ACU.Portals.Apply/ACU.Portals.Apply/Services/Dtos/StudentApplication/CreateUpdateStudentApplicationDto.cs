using System;
using ACU.Portals.Apply.Enum;

namespace ACU.Portals.Apply.Services.Dtos.StudentApplication
{
	public class CreateUpdateStudentApplicationDto
	{
        public string? ApplicationName { get; set; }
        public ApplicationStatus CurrentStatus { get; set; }
        public long? StudentDetailsId { get; set; }
       
    }
}

