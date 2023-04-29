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
    public class AdmissionStatusModel : AbpPageModel
    {
        public AdmissionStatusViewModel AdmissionStatus;

        public void OnGet()
        {
            AdmissionStatus = new AdmissionStatusViewModel();
        }

        public void OnPost()
        {

        }
    }
}

