using System;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace ACU.Portals.Apply.Entities
{
    public class AddressDetails : AuditedEntity<long>
    {
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public long? StudentDetailsId { get; set; }
        public virtual StudentDetails? StudentDetails{get;set;}
    }
}

