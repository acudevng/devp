using System;
using System.ComponentModel.DataAnnotations;
using ACU.Portals.Apply.Enum;

namespace ACU.Portals.Apply.Models.Applications
{
	public class Step3ViewModel
	{
		[Display(Name= "Mode of entry")]
		public EntryMode StudentEntryMode { get; set; }
        [Display(Name = "1st choice")]
        public string FirstChoice { get; set; }
        [Display(Name = "2nd choice")]
        public string SecondChoice { get; set; }
	}
}

