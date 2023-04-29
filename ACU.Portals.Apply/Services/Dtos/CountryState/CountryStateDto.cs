using System;
using Volo.Abp.Application.Dtos;

namespace ACU.Portals.Apply.Services.Dtos.CountryState
{
	public class CountryStateDto:EntityDto<long>
	{
        public string? StateName { get; set; }
        public long? CountryId { get; set; }
        
    }
}

