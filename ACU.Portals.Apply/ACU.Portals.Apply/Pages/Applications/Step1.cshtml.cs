using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACU.Portals.Apply.Models.Applications;
using ACU.Portals.Apply.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ACU.Portals.Apply.Pages.Applications
{
    public class Step1Model : AbpPageModel
    {
        [BindProperty]
        public Step1ViewModel Step1 { get; set; }

       /// public  CountryAppService _countryAppService;

        public void OnGet()
        {
            //_countryAppService = countryAppService;
            
            Step1 = new Step1ViewModel();
            Step1.Countries = new List<SelectListItem>();

            Step1.Countries.Add(new SelectListItem { Text = "Nigeria", Value = "1" });
            Step1.Countries.Add(new SelectListItem { Text = "Sweden", Value = "2" });
        }
        public void OnPost()
        {

        }
    }
}
