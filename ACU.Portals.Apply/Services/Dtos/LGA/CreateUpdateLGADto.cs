using System;
namespace ACU.Portals.Apply.Services.Dtos.LGA
{
	public class CreateUpdateLGADto
	{
        public string? Name { get; set; }
        public long CountryStateId { get; set; }
        public long CountryId { get; set; }
    }
}

