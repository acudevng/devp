using System;
using Volo.Abp.Domain.Entities;

namespace ACU.Portals.Apply.Entities
{
	public class Religion:Entity<long>
	{
		public string?  Name { get; set; }

	}
}

