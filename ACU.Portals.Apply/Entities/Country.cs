using System;
using Volo.Abp.Domain.Entities;

namespace ACU.Portals.Apply.Entities
{
	public class Country:Entity<long>
	{
		public string? CountryName { get; set; }
		public string? Nationality { get; set; }
	}
}

