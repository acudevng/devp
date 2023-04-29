using System;
namespace ACU.Portals.Apply.Services.Dtos.ExtraStudentDetails
{
	public class CreateUpdateExtraStudentDetailsDto
	{
        public string? Denomination { get; set; }
        public string? ParentName { get; set; }
        public string? FatherPhone { get; set; }
        public string? MotherPhone { get; set; }
        public string? ParentEmail { get; set; }
        public string? PhysicalDisability { get; set; }
        public string? NatureofDisability { get; set; }
        public long? StudentDetailsId { get; set; }
       // public virtual StudentDetails? StudentDetails { get; set; }
    }
}

