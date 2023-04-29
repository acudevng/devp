using System;
using Volo.Abp.Domain.Entities;

namespace ACU.Portals.Apply.Entities
{
	public class LGA:Entity<long>
	{
		public string? Name { get; set; }
		public long CountryStateId { get; set; }
		public CountryState? CountryState { get; set; }
		public long CountryId { get; set; }
		public Country? Country { get; set; }

	}
}

