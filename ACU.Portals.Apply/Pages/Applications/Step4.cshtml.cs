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
    public class Step4Model : AbpPageModel
    {
        public Step4ViewModel Step4 { get; set; }

        public void OnGet()
        {
            Step4 = new Step4ViewModel();
        }
        public void OnPost()
        {
            //get the Model
            //pass to the dto
            //insert in the service
            //Save in the database
            //Display successful message

        }
    }
}

