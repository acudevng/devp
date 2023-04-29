using System;
using Volo.Abp.Application.Dtos;

namespace ACU.Portals.Apply.Services.Dtos.Country
{
	public class CountryDto:EntityDto<long>
	{
        public string? CountryName { get; set; }
        public string? Nationality { get; set; }
    }
}

