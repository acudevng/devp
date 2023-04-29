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
    public class Step2Model : AbpPageModel
    {
        [BindProperty]
        public Step2ViewModel? Step2 { get; set; }

        public void OnGet()
        {
            Step2 = new Step2ViewModel();
        }
        public void OnPost()
        {

        }
    }
}
