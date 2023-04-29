using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.Identity.Web;

namespace ACU.Portals.Apply.Identity
{
    public abstract class IdentityPageModel : AbpPageModel
    {
        protected IdentityPageModel()
        {
            ObjectMapperContext = typeof(AbpIdentityWebModule);
        }
    }
}
