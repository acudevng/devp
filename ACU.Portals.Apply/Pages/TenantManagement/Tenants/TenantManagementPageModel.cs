using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.TenantManagement.Web;

namespace ACU.Portals.Apply.Pages.TenantManagement.Tenants
{
    public abstract class TenantManagementPageModel : AbpPageModel
    {
        public TenantManagementPageModel()
        {
            ObjectMapperContext = typeof(AbpTenantManagementWebModule);
        }
    }
}