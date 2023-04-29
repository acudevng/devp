using System;
using ACU.Portals.Apply.Enum;
using Volo.Abp.Domain.Entities;

namespace ACU.Portals.Apply.Entities
{
	public class StudentApplication:Entity<long>
	{
		public string? ApplicationName { get; set; }
		public ApplicationStatus CurrentStatus { get; set; }
        public long? StudentDetailsId { get; set; }
        public virtual StudentDetails? StudentDetails { get; set; }
    }
}

