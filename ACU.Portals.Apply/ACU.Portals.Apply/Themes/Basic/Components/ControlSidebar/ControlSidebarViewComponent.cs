using System;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace ACU.Portals.Apply.Themes.Components.ControlSidebar
{
    public class ControlSidebarViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/Basic/Components/ControlSidebar/Default.cshtml");
        }
    }
}

