using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ACU.Portals.Apply.Enum;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ACU.Portals.Apply.Models.Applications
{
	public class Step1ViewModel
	{
		[Required]
		public string? Surname { get; set; }

        [DisplayName("DOB")]
        public DateTime DateOfBirth { get; set; }

        public string? LGA { get; set; }
		[DisplayName("Marital Status")]
		public MaritalStatus MaritalStatus { get; set; }

		public string?  Firstname { get; set; }

		public Gender Gender { get; set; }

		public string? Country { get; set; }

		public string? Nationality { get; set; }

		[DisplayName("Physical Disability")]
        public Disability? PhysicalDisability { get; set; }

		public string? Othernames { get; set; }

        [DisplayName("State of Origin")]
        public string? StateOrigin { get; set; }

		public string? Religion { get; set; }

        [DisplayName("Nature of Disability")]
        public string? DisabilityNature { get; set; }

		public List<SelectListItem> Countries { get; set; }

		public List<SelectListItem> States { get; set; }
	}
}

