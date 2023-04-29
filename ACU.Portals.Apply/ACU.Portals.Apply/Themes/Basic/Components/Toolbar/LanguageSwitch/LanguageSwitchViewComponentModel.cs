using System;
using Volo.Abp.Localization;

namespace ACU.Portals.Apply.Themes.Components.Toolbar.LanguageSwitch
{
    public class LanguageSwitchViewComponentModel
    {
        public LanguageInfo? CurrentLanguage { get; set; }

        public List<LanguageInfo>? OtherLanguages { get; set; }
    }
}

