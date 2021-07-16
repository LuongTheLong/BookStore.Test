using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace UserManage.Web.Menus
{
    public class UserManageMenuContributor : IMenuContributor
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
            //Add main menu items.
            context.Menu.AddItem(new ApplicationMenuItem(UserManageMenus.Prefix, displayName: "UserManage", "~/UserManage", icon: "fa fa-users"));

            return Task.CompletedTask;
        }
    }
}