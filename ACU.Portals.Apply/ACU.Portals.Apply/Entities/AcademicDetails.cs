using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace ACU.Portals.Apply.Entities
{
	public class AcademicDetails:AuditedEntity<long>
	{
        public string? EducationalQualification { get; set; }
        public string? Institution { get; set; }
        public long? StudentDetailsId { get; set; }
        public virtual StudentDetails? StudentDetails { get; set; }
    }
}

