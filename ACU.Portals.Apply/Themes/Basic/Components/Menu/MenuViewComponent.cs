using System;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace ACU.Portals.Apply.Themes.Components.Menu
{
    public class MenuViewComponent : AbpViewComponent
    {
        private readonly IMenuManager _menuManager;

        public MenuViewComponent(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var pageUrl = RouteData.Values["page"];
            var menu = await _menuManager.GetAsync(StandardMenus.Main);
            SetMenuItemActivateCssClass(pageUrl?.ToString(), parentMenu: menu);
            return View("~/Themes/Basic/Components/Menu/Default.cshtml", menu);
        }

        void SetMenuItemActivateCssClass(string pageUrl, ApplicationMenuItem menuItem = null, ApplicationMenu parentMenu = null)
        {
            ApplicationMenuItemList withItems = menuItem?.Items ?? parentMenu?.Items;

            withItems.ForEach(m =>
            {
                //TODO: Menu Url ~/ replace with / clear ~ character
                m.Url = m.Url != null ? m.Url.Replace("~/", "/") : m.Url;

                if (m.Url != null && string.Compare(pageUrl, $"{m.Url}/index", StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    m.CssClass = "active";

                    if (menuItem != null) menuItem.CssClass = "active menu-open";
                }
                SetMenuItemActivateCssClass(pageUrl, m, parentMenu);
            });
        }

    }
}

