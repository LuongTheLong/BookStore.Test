using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace BookManage.Web.Menus
{
    public class BookManageMenuContributor : IMenuContributor
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
            context.Menu.AddItem(new ApplicationMenuItem(BookManageMenus.Prefix, displayName: "BookManage", "~/BookManage", icon: "fa fa-database"));

            return Task.CompletedTask;
        }
    }
}