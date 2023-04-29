using System;
using ACU.Portals.Apply.Enum;
using Volo.Abp.Domain.Entities.Auditing;

namespace ACU.Portals.Apply.Entities
{
	public class StudentDetails:AuditedEntity<long>
	{
        public string? Surname { get; set; }
        public string? FirstName { get; set; }		
        public string? SecondName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
        public string? Phone { get; set; }
		public string? Email { get; set; }
		public string? Country { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
       
		
	}
}

