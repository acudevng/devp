using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace ACU.Portals.Apply.Models.Applications
{
	public class Step2ViewModel
	{
        [Display(Name = "Residential Address")]
        public string? ResidentialAddress { get; set; }

		public string? Phone { get; set; }

		[Display(Name = "Contact Address")]
        [TextArea(Rows=2)]
        public string? ContactAddress { get; set; }

        [Display(Name = "Parent Email")]
        public string? ParentEmail { get; set; }

        [Display(Name = "Postal Address")]
        public string? PostalAddress { get; set; }

		public string? Denomination { get; set; }

        [Display(Name = "Father's Phone")]
        public string? FatherPhone { get; set; }

		public string? Email { get; set; }

        [Display(Name = "Parent Full Name")]
        public string? ParentFullName { get; set; }

        [Display(Name = "Mother's Phone")]
        public string? MotherPhone { get; set; }


	}
}

