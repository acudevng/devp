using System;
using Volo.Abp.Application.Dtos;

namespace ACU.Portals.Apply.Services.Dtos.LGA
{
	public class LGADto:EntityDto<long>
	{
        public string? Name { get; set; }
        public long CountryStateId { get; set; }
        public long CountryId { get; set; }
    }
}

