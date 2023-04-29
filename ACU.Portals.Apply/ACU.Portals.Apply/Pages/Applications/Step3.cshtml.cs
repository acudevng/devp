using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ACU.Portals.Apply.Models.Applications;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ACU.Portals.Apply.Pages.Applications
{
    public class Step3Model : AbpPageModel
    {
        [BindProperty]
        public Step3ViewModel? Step3 { get; set; }

        public void OnGet()
        {
            Step3 = new Step3ViewModel();
        }

        public void OnPost()
        {

        }
    }
}

