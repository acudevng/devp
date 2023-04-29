using ACU.Portals.Apply.Localization;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace ACU.Portals.Apply.Menus;

public class ApplyMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<ApplyResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                ApplyMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );

        context.Menu.Items.Insert(
          1,
          new ApplicationMenuItem(
              ApplyMenus.PaymentHistory,
              l["Menu:PaymentHistory"],
              "/ACUPay/PayHistory",
              //icon: "fas fa-home",
              order: 1
          )
      );

        context.Menu.Items.Insert(
          2,
          new ApplicationMenuItem(
              ApplyMenus.Support,
              l["Menu:Support"],
              "/Support/Support",
              //icon: "fas fa-home",
              order: 2
          )
      );

        context.Menu.Items.Insert(
          3,
          new ApplicationMenuItem(
              ApplyMenus.PasswordChange,
              l["Menu:PasswordChange"],
              "/Account/ForgotPassword",
              //icon: "fas fa-home",
              order: 3
          )
      );
        context.Menu.Items.Insert(
         4,
         new ApplicationMenuItem(
             ApplyMenus.Biodata,
             l["Menu:Biodata"],
             "/Applications/Step1",
             //icon: "fas fa-home",
             order: 4
         )
     );
        context.Menu.Items.Insert(
         5,
         new ApplicationMenuItem(
             ApplyMenus.Logout,
             l["Menu:Logout"],
             "/Account/Logout",
             //icon: "fas fa-home",
             order: 5
         )
     );

        if (ApplyModule.IsMultiTenant)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        return Task.CompletedTask;
    }
}
