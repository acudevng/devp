using System;
using Volo.Abp.Application.Dtos;

namespace ACU.Portals.Apply.Services.Dtos.AddressDetails
{
	public class AddressDetailsDto:EntityDto<long>
	{
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public long? StudentDetailsId { get; set; }
    
    }
}

