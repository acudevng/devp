using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ACU.Portals.Apply;

[Dependency(ReplaceServices = true)]
public class ApplyBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Apply";
}
