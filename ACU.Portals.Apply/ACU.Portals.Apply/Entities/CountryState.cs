using System;
using Volo.Abp.Domain.Entities;

namespace ACU.Portals.Apply.Entities
{
	public class CountryState :Entity<long>
	{
		public string? StateName {get;set ;}
		public long? CountryId { get; set; }
		public virtual Country? Country { get; set; }
	}

}

